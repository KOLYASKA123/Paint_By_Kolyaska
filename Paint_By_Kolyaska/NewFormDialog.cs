using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paint_By_Kolyaska
{
    public partial class NewFormDialog : Form
    {
        public Size size;

        public NewFormDialog()
        {
            InitializeComponent();
            setSizeValue(320, 240);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setSizeValue(320, 240);
            Text = size.Width.ToString() + "x" + size.Height.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            setSizeValue(640, 480);
            Text = size.Width.ToString() + "x" + size.Height.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            setSizeValue(800, 600);
            Text = size.Width.ToString() + "x" + size.Height.ToString();
        }

        public void setSizeValue(int width, int height)
        {
            size.Width = width;
            size.Height = height;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = !checkBox1.Checked;
            radioButton2.Enabled = !checkBox1.Checked;
            radioButton3.Enabled = !checkBox1.Checked;

            textBox1.Enabled = checkBox1.Checked;
            textBox2.Enabled = checkBox1.Checked;

            if (checkBox1.Checked)
            {
                if (textBox1.Text.Length > 0) size.Width = Convert.ToInt32(textBox1.Text);
                else size.Width = 0;
                if (textBox2.Text.Length > 0) size.Height = Convert.ToInt32(textBox2.Text);
                else size.Height = 0;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    setSizeValue(320, 240);
                }
                else if (radioButton2.Checked)
                {
                    setSizeValue(640, 480);
                }
                else if (radioButton3.Checked)
                {
                    setSizeValue(800, 600);
                }
            }

            Text = size.Width.ToString() + "x" + size.Height.ToString();

            disableOkButton();
        }

        private void validCharacters(KeyPressEventArgs e, System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text.Length == 0)
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9'))
                {
                    return;
                }
            }
            else 
            {
                if (((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '\b')) && (textBox.Text.Length < 4))
                {
                    return;
                }
                else if ((textBox.Text.Length == 4) && (e.KeyChar == '\b'))
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validCharacters(e, textBox1);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validCharacters(e, textBox2);
        }

        private void disableOkButton()
        {
            if (checkBox1.Checked)
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    button1.Enabled = false;
                    return;
                }
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck(textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck(textBox2);
        }

        private void textBoxCheck(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Text.Length > 0)
            {
                if (textBox == textBox1) size.Width = Convert.ToInt32(textBox.Text);
                else if (textBox == textBox2) size.Height = Convert.ToInt32(textBox.Text);
                string str = textBox.Text;
                if (str[0] == '0')
                {
                    textBox.Text = "";
                }
            }
            else
            {
                if (textBox == textBox1) size.Width = 0;
                else if (textBox == textBox2) size.Height = 0;
            }

            Text = size.Width.ToString() + "x" + size.Height.ToString();
            disableOkButton();
        }
    }
}
