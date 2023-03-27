namespace Paint_By_Kolyaska
{
    public partial class WorkSpace : UserControl
    {
        public WorkSpace(Size size, LF thisForm, MF mainForm)
        {
            InitializeComponent();
            Anchor = AnchorStyles.None;
            BackColor = Color.White;
            Size = size;
            this.thisForm = thisForm;
            this.mainForm = mainForm;
        }

        public Graphics g;
        public BufferedGraphics dblBuff;
        public BufferedGraphicsContext buffContext;

        readonly MF mainForm;
        readonly LF thisForm;

        public List<Figure> lst = new List<Figure>();
        public List<Figure> dashLst = new List<Figure>();

        int prevX, prevY;

        private void WorkSpace_MouseDown(object sender, MouseEventArgs e)
        {
            prevX = e.X; prevY = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                InitializeChoosedFigure(e);
            }
        }

        private void WorkSpace_MouseMove(object sender, MouseEventArgs e)
        {
            if (mainForm.ActiveMdiChild == thisForm)
            {
                RedrawOperations(e);
            }
        }

        private void WorkSpace_MouseUp(object sender, MouseEventArgs e)
        {
            if (mainForm.paintFlag && e.Button == MouseButtons.Left)
            {
                ConfirmActions(e);
            }
        }

        private void WorkSpace_Paint(object sender, PaintEventArgs e)
        {
            if (lst.Count > 0) foreach (Figure f in lst) f.Draw(e.Graphics);
            if (dashLst.Count > 0) foreach (Figure f in dashLst) f.DrawDash(e.Graphics);
        }

        private void WorkSpace_MouseLeave(object sender, EventArgs e)
        {
            mainForm.workSpaceCoordVal.Text = "    -- ; --    ";
        }

        private void WorkSpace_Load(object sender, EventArgs e)
        {
            buffContext = new BufferedGraphicsContext();
            buffContext.MaximumBuffer = Size;
            g = CreateGraphics();
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            dblBuff = buffContext.Allocate(g, DisplayRectangle);
        }

        private void WorkSpace_MouseClick(object sender, MouseEventArgs e)
        {
            if (mainForm.selectionFlag)
            {
                if (mainForm.cursorMovedFlag)
                {
                    if (!mainForm.dragFlag)
                    {
                        for (int i = lst.Count - 1; i >= 0; i--)
                        {
                            if (lst[i].IsSelected(mainForm.fig.figureBox))
                            {
                                dashLst.Add(lst[i]);
                                lst.Remove(lst[i]);
                            }
                        }
                        return;
                    }
                }
                else
                {
                    for (int i = lst.Count - 1; i >= 0; i--)
                    {
                        if (lst[i].IsSelected(mainForm.fig.figureBox))
                        {
                            dashLst.Add(lst[i]);
                            lst.Remove(lst[i]);
                            return;
                        }
                    }
                    foreach (Figure f in dashLst)
                    {
                        lst.Add(f);
                    }
                    dashLst.Clear();
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter) textBox1.AppendText("\n");
            else if (e.KeyCode == Keys.Enter)
            {
                mainForm.fig.SetText(textBox1.Text);
                mainForm.fig.Draw(g);
                lst.Add(mainForm.fig);

                if (!thisForm.saveFlag)
                {
                    if (thisForm.openedFlag)
                        mainForm.menuSaveFile.Enabled = true;
                    thisForm.saveFlag = true;
                }

                textBox1.Visible = false;
                Invalidate();
            }
        }
    }
}
