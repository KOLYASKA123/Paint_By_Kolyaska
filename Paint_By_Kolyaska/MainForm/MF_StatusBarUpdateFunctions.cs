using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    public partial class MF : Form
    {
        public void changeLabelColor(Color color, ref ToolStripStatusLabel label)
        {
            Bitmap Btm = new Bitmap(label.Width, label.Height);
            Rectangle r = new Rectangle(0, 0, label.Width - 1, label.Height - 1);
            Graphics g = Graphics.FromImage(Btm);
            g.FillRectangle(new SolidBrush(color), r);
            g.DrawRectangle(new Pen(Color.Black, 1), r);
            label.BackgroundImage = Btm;
        }

        public void changeLabelPenSizeVal()
        {
            penSizeVal.Text = " " + optionOutlineWidth.ToString() + " ";
        }

        public void changeLabeldocSizeVal(LF f)
        {
            docSizeVal.Text = "  " + f.workSpace.Width.ToString() + "x" + f.workSpace.Height.ToString() + "  ";
        }

        public void changeLabelWorkSpaceCoordVal(MouseEventArgs e)
        {
            workSpaceCoordVal.Text = "  " + e.X.ToString() + " ; " + e.Y.ToString() + "  ";
        }

        public void changeLabelFont()
        {
            fontSizeVal.Text = optionFont.Size.ToString();
            fontVal.Text = optionFont.Name;
            fontVal.Font = new Font(optionFont.Name, 9);
        }
    }
}
