namespace Paint_By_Kolyaska
{
    partial class WorkSpace
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(25, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // WorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "WorkSpace";
            this.Load += new System.EventHandler(this.WorkSpace_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WorkSpace_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseDown);
            this.MouseLeave += new System.EventHandler(this.WorkSpace_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorkSpace_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox textBox1;
    }
}
