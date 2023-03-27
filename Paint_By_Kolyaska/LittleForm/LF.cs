using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_By_Kolyaska
{   
    public partial class LF : Form
    {
        /// <summary>
        /// Класс дочерних окон MF (LF - LittleForm).
        /// </summary>
        /// <param name="size">Размер рабочей области в дочернем окне.</param>
        public LF(Size size, MF owner)
        {
            InitializeComponent();
            ClientSize = size;
            AutoScrollMinSize = size;
            workSpace = new WorkSpace(size, this, owner);
            Controls.Clear();
            Controls.Add(workSpace);
            //pc.Anchor = AnchorStyles.None;
        }

        public bool saveFlag = false;
        public bool openedFlag = false;

        public WorkSpace workSpace;
        //public PictureBox pc;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveFlag) 
            {
                DialogResult dialogResult = MessageBox.Show("Сохранить изменения?", "Выполняется закрытие файла", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    if (openedFlag) ((MF)ParentForm).Save(this);
                    else e.Cancel = ((MF)ParentForm).SaveAs(this);
                    workSpace.dblBuff.Dispose();
                    workSpace.buffContext.Dispose();
                    workSpace.g.Dispose();
                }

                else if (dialogResult == DialogResult.No)
                {
                    workSpace.dblBuff.Dispose();
                    workSpace.buffContext.Dispose();
                    workSpace.g.Dispose();
                }
                else if (dialogResult == DialogResult.Cancel) e.Cancel = true;

            }
            if (((MF)ParentForm).MdiChildren.Length == 1 && !e.Cancel)
            {
                ((MF)ParentForm).menuSaveFile.Enabled = false;
                ((MF)ParentForm).menuSaveFileAs.Enabled = false;
                ((MF)ParentForm).toolBarSaveFile.Enabled = false;
                ((MF)ParentForm).docSizeVal.Text = "    -- ; --    ";
                ((MF)ParentForm).workSpaceCoordVal.Text = "    -- ; --    ";
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            ((MF)ParentForm).menuSaveFile.Enabled = openedFlag && saveFlag;
            ((MF)ParentForm).menuSaveFileAs.Enabled = true;
            ((MF)ParentForm).changeLabeldocSizeVal(this);
        }
    }
}
