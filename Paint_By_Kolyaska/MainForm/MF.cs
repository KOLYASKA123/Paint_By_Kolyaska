using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing;

namespace Paint_By_Kolyaska
{
    public enum FigType
    {
        Line,
        Curve,
        Rect,
        Ellipse,
        Text
    }

    /// <summary>
    /// Класс главного окна программы (MF - MainForm).
    /// </summary>
    public partial class MF : Form
    {
        public MF()
        {
            InitializeComponent();
            Size = new Size(1280, 720);
            toolStrip1.Renderer = new ToolBarNotRounded();
            changeLabelPenSizeVal();
            changeLabelColor(optionOutlineColor, ref penColorVal);
            changeLabelColor(optionFillColor, ref fillColorVal);
            changeLabelFont();
        }

        public Figure fig;
        public bool paintFlag;
        public bool cursorMovedFlag;
        public bool selectionFlag = false;
        public bool dragFlag = false;
        public FigType figType = FigType.Line;

        public Color optionOutlineColor = Color.Black;          //
        public Color optionFillColor = Color.White;             //
        public int optionOutlineWidth = 1;                      // Дефолтные настройки рисования
        public bool optionFillFlag = false;                     //
        public Font optionFont = new("Times New Roman", 12);    //


        #region Ненужная херня
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();

            if (e.Button == MouseButtons.Left)
            {
                g.Clear(Color.White);
                string s = "Координаты курсора: (" + e.X + ", " + e.Y + ")";
                g.DrawString(s, new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(10, 10));

            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Нажата правая кнопка мыши.", "Диалоговое окно");
                g.Clear(Color.White);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion Ненужная херня

        #region Файловые события

        private void NewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            Save((LF)ActiveMdiChild);
        }

        private void SaveFileAs_Click(object sender, EventArgs e)
        {
            SaveAs((LF)ActiveMdiChild);
        }

        private void toolBarSaveFile_Click(object sender, EventArgs e)
        {
            if (!menuSaveFile.Enabled) SaveAs((LF)ActiveMdiChild);
            else Save((LF)ActiveMdiChild);
        }

        #endregion Файловые события

        #region События изменения настроек рисования

        private void ChangePenSize_Click(object sender, EventArgs e)
        {
            changeWidth();
        }

        private void ChangePenColor_Click(object sender, EventArgs e)
        {
            changeColor(ref optionOutlineColor, ref penColorVal);
        }

        private void ChangeFillColor_Click(object sender, EventArgs e)
        {
            changeColor(ref optionFillColor, ref fillColorVal);
        }

        private void ChangeFillFlag_Click(object sender, EventArgs e)
        {
            changeFillFlag();
        }

        private void ChangeFont_Click(object sender, EventArgs e)
        {
            changeFont();
        }

        private void toolBarSelection_Click(object sender, EventArgs e)
        {
            selectionFlag = !selectionFlag;
            toolBarSelection.Checked = selectionFlag;
            if (ActiveMdiChild != null && ((LF)ActiveMdiChild).workSpace.dashLst.Count > 0 && !selectionFlag)
            {
                ((LF)ActiveMdiChild).workSpace.lst.AddRange(((LF)ActiveMdiChild).workSpace.dashLst);
                ((LF)ActiveMdiChild).workSpace.dashLst.Clear();
                ((LF)ActiveMdiChild).workSpace.Invalidate();
            }
        }

        #endregion События изменения настроек рисования

        #region События выбора фигуры

        private void ChooseLine_Click(object sender, EventArgs e)
        {
            chooseLine();
        }

        private void ChooseCurva_Click(object sender, EventArgs e)
        {
            chooseCurva();
        }

        private void ChooseRect_Click(object sender, EventArgs e)
        {
            chooseRect();
        }

        private void ChooseEllipse_Click(object sender, EventArgs e)
        {
            chooseEllipse();
        }

        private void ChooseText_Click(object sender, EventArgs e)
        {
            chooseText();
        }

        #endregion События выбора фигуры

        private void menuDeleteDashFigs_Click(object sender, EventArgs e)
        {
            if (((LF)ActiveMdiChild).workSpace.dashLst.Count > 0)
            {
                ((LF)ActiveMdiChild).workSpace.dashLst.Clear();
                ((LF)ActiveMdiChild).workSpace.Invalidate();
            }
        }
    }
}