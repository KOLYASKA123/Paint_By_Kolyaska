namespace Paint_By_Kolyaska
{
    partial class MF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MF));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPenSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFillColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFillFlag = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.фигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCurva = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuText = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteDashFigs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.penSizeStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.penSizeVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.penColorStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.penColorVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.fillColorStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.fillColorVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.docSizeStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.docSizeVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.workSpaceCoordStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.workSpaceCoordVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontSizeStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontSizeVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBarNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolBarOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolBarSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarSelection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarPenColor = new System.Windows.Forms.ToolStripButton();
            this.toolBarPenSize = new System.Windows.Forms.ToolStripButton();
            this.toolBarFillColor = new System.Windows.Forms.ToolStripButton();
            this.toolBarFillFlag = new System.Windows.Forms.ToolStripButton();
            this.toolBarFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarLine = new System.Windows.Forms.ToolStripButton();
            this.toolBarCurva = new System.Windows.Forms.ToolStripButton();
            this.toolBarRect = new System.Windows.Forms.ToolStripButton();
            this.toolBarEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolBarText = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.фигурыToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewFile,
            this.menuOpenFile,
            this.menuSaveFile,
            this.menuSaveFileAs});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menuNewFile
            // 
            this.menuNewFile.Name = "menuNewFile";
            this.menuNewFile.Size = new System.Drawing.Size(163, 22);
            this.menuNewFile.Text = "Новый";
            this.menuNewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // menuOpenFile
            // 
            this.menuOpenFile.Name = "menuOpenFile";
            this.menuOpenFile.Size = new System.Drawing.Size(163, 22);
            this.menuOpenFile.Text = "Открыть";
            this.menuOpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // menuSaveFile
            // 
            this.menuSaveFile.Enabled = false;
            this.menuSaveFile.Name = "menuSaveFile";
            this.menuSaveFile.Size = new System.Drawing.Size(163, 22);
            this.menuSaveFile.Text = "Сохранить";
            this.menuSaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // menuSaveFileAs
            // 
            this.menuSaveFileAs.Enabled = false;
            this.menuSaveFileAs.Name = "menuSaveFileAs";
            this.menuSaveFileAs.Size = new System.Drawing.Size(163, 22);
            this.menuSaveFileAs.Text = "Сохранить как...";
            this.menuSaveFileAs.Click += new System.EventHandler(this.SaveFileAs_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.windowToolStripMenuItem.Text = "Окно";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPenColor,
            this.menuPenSize,
            this.menuFillColor,
            this.menuFillFlag,
            this.menuFont});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // menuPenColor
            // 
            this.menuPenColor.Name = "menuPenColor";
            this.menuPenColor.Size = new System.Drawing.Size(156, 22);
            this.menuPenColor.Text = "Цвет пера";
            this.menuPenColor.Click += new System.EventHandler(this.ChangePenColor_Click);
            // 
            // menuPenSize
            // 
            this.menuPenSize.Name = "menuPenSize";
            this.menuPenSize.Size = new System.Drawing.Size(156, 22);
            this.menuPenSize.Text = "Размер пера";
            this.menuPenSize.Click += new System.EventHandler(this.ChangePenSize_Click);
            // 
            // menuFillColor
            // 
            this.menuFillColor.Enabled = false;
            this.menuFillColor.Name = "menuFillColor";
            this.menuFillColor.Size = new System.Drawing.Size(156, 22);
            this.menuFillColor.Text = "Цвет заливки";
            this.menuFillColor.Click += new System.EventHandler(this.ChangeFillColor_Click);
            // 
            // menuFillFlag
            // 
            this.menuFillFlag.Enabled = false;
            this.menuFillFlag.Name = "menuFillFlag";
            this.menuFillFlag.Size = new System.Drawing.Size(156, 22);
            this.menuFillFlag.Text = "Заливка фигур";
            this.menuFillFlag.Click += new System.EventHandler(this.ChangeFillFlag_Click);
            // 
            // menuFont
            // 
            this.menuFont.Enabled = false;
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(156, 22);
            this.menuFont.Text = "Шрифт";
            this.menuFont.Click += new System.EventHandler(this.ChangeFont_Click);
            // 
            // фигурыToolStripMenuItem
            // 
            this.фигурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLine,
            this.menuCurva,
            this.menuRect,
            this.menuEllipse,
            this.menuText});
            this.фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            this.фигурыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.фигурыToolStripMenuItem.Text = "Фигуры";
            // 
            // menuLine
            // 
            this.menuLine.Checked = true;
            this.menuLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuLine.Name = "menuLine";
            this.menuLine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.menuLine.Size = new System.Drawing.Size(203, 22);
            this.menuLine.Text = "Прямая линия";
            this.menuLine.Click += new System.EventHandler(this.ChooseLine_Click);
            // 
            // menuCurva
            // 
            this.menuCurva.Name = "menuCurva";
            this.menuCurva.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.menuCurva.Size = new System.Drawing.Size(203, 22);
            this.menuCurva.Text = "Кривая линия";
            this.menuCurva.Click += new System.EventHandler(this.ChooseCurva_Click);
            // 
            // menuRect
            // 
            this.menuRect.Name = "menuRect";
            this.menuRect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.menuRect.Size = new System.Drawing.Size(203, 22);
            this.menuRect.Text = "Прямоугольник";
            this.menuRect.Click += new System.EventHandler(this.ChooseRect_Click);
            // 
            // menuEllipse
            // 
            this.menuEllipse.Name = "menuEllipse";
            this.menuEllipse.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.menuEllipse.Size = new System.Drawing.Size(203, 22);
            this.menuEllipse.Text = "Эллипс";
            this.menuEllipse.Click += new System.EventHandler(this.ChooseEllipse_Click);
            // 
            // menuText
            // 
            this.menuText.Name = "menuText";
            this.menuText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.menuText.Size = new System.Drawing.Size(203, 22);
            this.menuText.Text = "Текстовое поле";
            this.menuText.Click += new System.EventHandler(this.ChooseText_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeleteDashFigs});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // menuDeleteDashFigs
            // 
            this.menuDeleteDashFigs.Name = "menuDeleteDashFigs";
            this.menuDeleteDashFigs.ShortcutKeyDisplayString = "Del";
            this.menuDeleteDashFigs.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDeleteDashFigs.Size = new System.Drawing.Size(142, 22);
            this.menuDeleteDashFigs.Text = "Удалить";
            this.menuDeleteDashFigs.Click += new System.EventHandler(this.menuDeleteDashFigs_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "Environment.CurrentDirectory";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "Environment.CurrentDirectory";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penSizeStatusText,
            this.penSizeVal,
            this.penColorStatusText,
            this.penColorVal,
            this.fillColorStatusText,
            this.fillColorVal,
            this.docSizeStatusText,
            this.docSizeVal,
            this.workSpaceCoordStatusText,
            this.workSpaceCoordVal,
            this.fontSizeStatusText,
            this.fontSizeVal,
            this.fontStatusText,
            this.fontVal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // penSizeStatusText
            // 
            this.penSizeStatusText.ImageTransparentColor = System.Drawing.Color.Black;
            this.penSizeStatusText.LinkColor = System.Drawing.Color.DimGray;
            this.penSizeStatusText.Name = "penSizeStatusText";
            this.penSizeStatusText.Size = new System.Drawing.Size(79, 20);
            this.penSizeStatusText.Text = "Размер пера:";
            // 
            // penSizeVal
            // 
            this.penSizeVal.BackColor = System.Drawing.Color.White;
            this.penSizeVal.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.penSizeVal.Name = "penSizeVal";
            this.penSizeVal.Size = new System.Drawing.Size(19, 20);
            this.penSizeVal.Text = "    ";
            // 
            // penColorStatusText
            // 
            this.penColorStatusText.Name = "penColorStatusText";
            this.penColorStatusText.Size = new System.Drawing.Size(62, 20);
            this.penColorStatusText.Text = "Цвет пера";
            // 
            // penColorVal
            // 
            this.penColorVal.AutoSize = false;
            this.penColorVal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penColorVal.Name = "penColorVal";
            this.penColorVal.Size = new System.Drawing.Size(20, 20);
            this.penColorVal.Text = "             ";
            // 
            // fillColorStatusText
            // 
            this.fillColorStatusText.Name = "fillColorStatusText";
            this.fillColorStatusText.Size = new System.Drawing.Size(80, 20);
            this.fillColorStatusText.Text = "Цвет заливки";
            this.fillColorStatusText.Visible = false;
            // 
            // fillColorVal
            // 
            this.fillColorVal.AutoSize = false;
            this.fillColorVal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColorVal.Name = "fillColorVal";
            this.fillColorVal.Size = new System.Drawing.Size(20, 20);
            this.fillColorVal.Text = "             ";
            this.fillColorVal.Visible = false;
            // 
            // docSizeStatusText
            // 
            this.docSizeStatusText.Name = "docSizeStatusText";
            this.docSizeStatusText.Size = new System.Drawing.Size(111, 20);
            this.docSizeStatusText.Text = "Размер документа:";
            // 
            // docSizeVal
            // 
            this.docSizeVal.Name = "docSizeVal";
            this.docSizeVal.Size = new System.Drawing.Size(60, 20);
            this.docSizeVal.Text = "    -- ; --    ";
            // 
            // workSpaceCoordStatusText
            // 
            this.workSpaceCoordStatusText.Name = "workSpaceCoordStatusText";
            this.workSpaceCoordStatusText.Size = new System.Drawing.Size(126, 20);
            this.workSpaceCoordStatusText.Text = "Координаты курсора:";
            // 
            // workSpaceCoordVal
            // 
            this.workSpaceCoordVal.Name = "workSpaceCoordVal";
            this.workSpaceCoordVal.Size = new System.Drawing.Size(60, 20);
            this.workSpaceCoordVal.Text = "    -- ; --    ";
            // 
            // fontSizeStatusText
            // 
            this.fontSizeStatusText.Name = "fontSizeStatusText";
            this.fontSizeStatusText.Size = new System.Drawing.Size(98, 20);
            this.fontSizeStatusText.Text = "Размер шрифта:";
            this.fontSizeStatusText.Visible = false;
            // 
            // fontSizeVal
            // 
            this.fontSizeVal.Name = "fontSizeVal";
            this.fontSizeVal.Size = new System.Drawing.Size(19, 20);
            this.fontSizeVal.Text = "    ";
            this.fontSizeVal.Visible = false;
            // 
            // fontStatusText
            // 
            this.fontStatusText.Name = "fontStatusText";
            this.fontStatusText.Size = new System.Drawing.Size(49, 20);
            this.fontStatusText.Text = "Шрифт:";
            this.fontStatusText.Visible = false;
            // 
            // fontVal
            // 
            this.fontVal.Name = "fontVal";
            this.fontVal.Size = new System.Drawing.Size(106, 20);
            this.fontVal.Text = "Times New Roman";
            this.fontVal.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 680);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarNewFile,
            this.toolBarOpenFile,
            this.toolBarSaveFile,
            this.toolStripSeparator1,
            this.toolBarSelection,
            this.toolStripSeparator3,
            this.toolBarPenColor,
            this.toolBarPenSize,
            this.toolBarFillColor,
            this.toolBarFillFlag,
            this.toolBarFont,
            this.toolStripSeparator2,
            this.toolBarLine,
            this.toolBarCurva,
            this.toolBarRect,
            this.toolBarEllipse,
            this.toolBarText});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1005, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBarNewFile
            // 
            this.toolBarNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolBarNewFile.Image")));
            this.toolBarNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarNewFile.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolBarNewFile.Name = "toolBarNewFile";
            this.toolBarNewFile.Size = new System.Drawing.Size(24, 24);
            this.toolBarNewFile.Text = "Новый файл";
            this.toolBarNewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // toolBarOpenFile
            // 
            this.toolBarOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolBarOpenFile.Image")));
            this.toolBarOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarOpenFile.Name = "toolBarOpenFile";
            this.toolBarOpenFile.Size = new System.Drawing.Size(24, 24);
            this.toolBarOpenFile.Text = "Открыть";
            this.toolBarOpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // toolBarSaveFile
            // 
            this.toolBarSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarSaveFile.Enabled = false;
            this.toolBarSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("toolBarSaveFile.Image")));
            this.toolBarSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarSaveFile.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolBarSaveFile.Name = "toolBarSaveFile";
            this.toolBarSaveFile.Size = new System.Drawing.Size(24, 24);
            this.toolBarSaveFile.Text = "Сохранить";
            this.toolBarSaveFile.Click += new System.EventHandler(this.toolBarSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolBarSelection
            // 
            this.toolBarSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarSelection.Image = ((System.Drawing.Image)(resources.GetObject("toolBarSelection.Image")));
            this.toolBarSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarSelection.Margin = new System.Windows.Forms.Padding(5, 1, 5, 2);
            this.toolBarSelection.Name = "toolBarSelection";
            this.toolBarSelection.Size = new System.Drawing.Size(24, 24);
            this.toolBarSelection.Text = "Выделение";
            this.toolBarSelection.Click += new System.EventHandler(this.toolBarSelection_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolBarPenColor
            // 
            this.toolBarPenColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarPenColor.Image = ((System.Drawing.Image)(resources.GetObject("toolBarPenColor.Image")));
            this.toolBarPenColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarPenColor.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolBarPenColor.Name = "toolBarPenColor";
            this.toolBarPenColor.Size = new System.Drawing.Size(24, 24);
            this.toolBarPenColor.Text = "Цвет пера";
            this.toolBarPenColor.Click += new System.EventHandler(this.ChangePenColor_Click);
            // 
            // toolBarPenSize
            // 
            this.toolBarPenSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarPenSize.Image = ((System.Drawing.Image)(resources.GetObject("toolBarPenSize.Image")));
            this.toolBarPenSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarPenSize.Name = "toolBarPenSize";
            this.toolBarPenSize.Size = new System.Drawing.Size(24, 24);
            this.toolBarPenSize.Text = "Размер пера";
            this.toolBarPenSize.Click += new System.EventHandler(this.ChangePenSize_Click);
            // 
            // toolBarFillColor
            // 
            this.toolBarFillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarFillColor.Enabled = false;
            this.toolBarFillColor.Image = ((System.Drawing.Image)(resources.GetObject("toolBarFillColor.Image")));
            this.toolBarFillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarFillColor.Name = "toolBarFillColor";
            this.toolBarFillColor.Size = new System.Drawing.Size(24, 24);
            this.toolBarFillColor.Text = "Цвет заливки";
            this.toolBarFillColor.Click += new System.EventHandler(this.ChangeFillColor_Click);
            // 
            // toolBarFillFlag
            // 
            this.toolBarFillFlag.CheckOnClick = true;
            this.toolBarFillFlag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarFillFlag.Enabled = false;
            this.toolBarFillFlag.Image = ((System.Drawing.Image)(resources.GetObject("toolBarFillFlag.Image")));
            this.toolBarFillFlag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarFillFlag.Name = "toolBarFillFlag";
            this.toolBarFillFlag.Size = new System.Drawing.Size(24, 24);
            this.toolBarFillFlag.Text = "Заливка фигур";
            this.toolBarFillFlag.Click += new System.EventHandler(this.ChangeFillFlag_Click);
            // 
            // toolBarFont
            // 
            this.toolBarFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarFont.Enabled = false;
            this.toolBarFont.Image = ((System.Drawing.Image)(resources.GetObject("toolBarFont.Image")));
            this.toolBarFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarFont.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.toolBarFont.Name = "toolBarFont";
            this.toolBarFont.Size = new System.Drawing.Size(24, 24);
            this.toolBarFont.Text = "Шрифт";
            this.toolBarFont.Click += new System.EventHandler(this.ChangeFont_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolBarLine
            // 
            this.toolBarLine.Checked = true;
            this.toolBarLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarLine.Image = ((System.Drawing.Image)(resources.GetObject("toolBarLine.Image")));
            this.toolBarLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarLine.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolBarLine.Name = "toolBarLine";
            this.toolBarLine.Size = new System.Drawing.Size(24, 24);
            this.toolBarLine.Text = "Прямая линия";
            this.toolBarLine.Click += new System.EventHandler(this.ChooseLine_Click);
            // 
            // toolBarCurva
            // 
            this.toolBarCurva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarCurva.Image = ((System.Drawing.Image)(resources.GetObject("toolBarCurva.Image")));
            this.toolBarCurva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarCurva.Name = "toolBarCurva";
            this.toolBarCurva.Size = new System.Drawing.Size(24, 24);
            this.toolBarCurva.Text = "Кривая линия";
            this.toolBarCurva.Click += new System.EventHandler(this.ChooseCurva_Click);
            // 
            // toolBarRect
            // 
            this.toolBarRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarRect.Image = ((System.Drawing.Image)(resources.GetObject("toolBarRect.Image")));
            this.toolBarRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarRect.Name = "toolBarRect";
            this.toolBarRect.Size = new System.Drawing.Size(24, 24);
            this.toolBarRect.Text = "Прямоугольник";
            this.toolBarRect.Click += new System.EventHandler(this.ChooseRect_Click);
            // 
            // toolBarEllipse
            // 
            this.toolBarEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolBarEllipse.Image")));
            this.toolBarEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarEllipse.Name = "toolBarEllipse";
            this.toolBarEllipse.Size = new System.Drawing.Size(24, 24);
            this.toolBarEllipse.Text = "Эллипс";
            this.toolBarEllipse.Click += new System.EventHandler(this.ChooseEllipse_Click);
            // 
            // toolBarText
            // 
            this.toolBarText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarText.Image = ((System.Drawing.Image)(resources.GetObject("toolBarText.Image")));
            this.toolBarText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarText.Name = "toolBarText";
            this.toolBarText.Size = new System.Drawing.Size(24, 24);
            this.toolBarText.Text = "Текстовое поле";
            this.toolBarText.Click += new System.EventHandler(this.ChooseText_Click);
            // 
            // MF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            //this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MF";
            this.Text = " Paint By Kolyaska";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem menuNewFile;
        private ToolStripMenuItem menuOpenFile;
        public ToolStripMenuItem menuSaveFile;
        public ToolStripMenuItem menuSaveFileAs;
        public SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem menuPenColor;
        public ToolStripMenuItem menuFillColor;
        private ToolStripMenuItem menuPenSize;
        private ToolStripMenuItem menuFillFlag;
        private ToolStripMenuItem фигурыToolStripMenuItem;
        public ToolStripMenuItem menuLine;
        public ToolStripMenuItem menuCurva;
        public ToolStripMenuItem menuRect;
        public ToolStripMenuItem menuEllipse;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel penSizeStatusText;
        private ToolStripStatusLabel penColorStatusText;
        private ToolStripStatusLabel fillColorStatusText;
        private ToolStripStatusLabel docSizeStatusText;
        private ToolStripStatusLabel workSpaceCoordStatusText;
        private Splitter splitter1;
        public ToolStripStatusLabel penSizeVal;
        public ToolStripStatusLabel penColorVal;
        public ToolStripStatusLabel fillColorVal;
        public ToolStripStatusLabel docSizeVal;
        public ToolStripStatusLabel workSpaceCoordVal;
        private ToolStrip toolStrip1;
        private ToolStripButton toolBarNewFile;
        private ToolStripButton toolBarOpenFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolBarPenColor;
        private ToolStripButton toolBarFillColor;
        private ToolStripButton toolBarFillFlag;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolBarLine;
        private ToolStripButton toolBarCurva;
        private ToolStripButton toolBarRect;
        private ToolStripButton toolBarEllipse;
        public ToolStripButton toolBarSaveFile;
        private ToolStripButton toolBarPenSize;
        private ToolStripStatusLabel fontSizeStatusText;
        private ToolStripStatusLabel fontSizeVal;
        private ToolStripStatusLabel fontStatusText;
        private ToolStripStatusLabel fontVal;
        private ToolStripMenuItem menuText;
        private ToolStripButton toolBarText;
        private ToolStripMenuItem menuFont;
        private ToolStripButton toolBarFont;
        private ToolStripButton toolBarSelection;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem menuDeleteDashFigs;
    }
}