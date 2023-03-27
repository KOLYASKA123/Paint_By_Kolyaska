using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    public partial class MF : Form
    {
        private void changeColor(ref Color color, ref ToolStripStatusLabel label)
        {
            ColorDialog dialogColor = new ColorDialog();
            dialogColor.Color = color;
            DialogResult result = dialogColor.ShowDialog(this);


            if (result == DialogResult.OK)
            {
                color = dialogColor.Color;
                changeLabelColor(color, ref label);
            }
        }

        private void changeWidth()
        {
            Width dialogWidth = new Width();
            dialogWidth.comboBox1.Text = optionOutlineWidth.ToString();
            DialogResult result = dialogWidth.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                optionOutlineWidth = Convert.ToInt32(dialogWidth.comboBox1.SelectedItem);
                dialogWidth.comboBox1.Text = dialogWidth.comboBox1.SelectedItem.ToString();
                dialogWidth.Close();
                changeLabelPenSizeVal();
            }
            else if (result == DialogResult.Cancel)
            {
                dialogWidth.Close();
            }
        }

        private void changeFillFlag()
        {
            menuFillFlag.Checked = !menuFillFlag.Checked;
            optionFillFlag = menuFillFlag.Checked;
            menuFillColor.Enabled = menuFillFlag.Checked;
            toolBarFillColor.Enabled = menuFillFlag.Checked;
        }

        private void changeFont()
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = optionFont;
            DialogResult result = fontDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                optionFont = fontDialog.Font;
                changeLabelFont();
            }
        }
    }
}
