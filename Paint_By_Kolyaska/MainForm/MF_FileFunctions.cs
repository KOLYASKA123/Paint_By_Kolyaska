using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Paint_By_Kolyaska
{
    public partial class MF : Form
    {
        public void NewFile()
        {
            NewFormDialog newFormDialog = new NewFormDialog();
            DialogResult result = newFormDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Form f = new LF(newFormDialog.size, this);
                f.MdiParent = this;
                f.Text = "Рисунок " + this.MdiChildren.Length.ToString();
                if (!this.menuSaveFileAs.Enabled)
                {
                    this.menuSaveFileAs.Enabled = true;
                    this.toolBarSaveFile.Enabled = true;
                }
                newFormDialog.Close();
                newFormDialog.Dispose();
                f.Show();
                changeLabeldocSizeVal((LF)ActiveMdiChild);
            }
        }

        public void OpenFile()
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                SaveData data = (SaveData)formatter.Deserialize(stream);
                Form f = new LF(data.size, this);
                ((LF)f).openedFlag = true;
                f.MdiParent = this;
                f.Text = openFileDialog1.FileName;
                ((LF)f).workSpace.lst = data.listOfFigures;
                f.Show();
                if (!this.menuSaveFileAs.Enabled)
                {
                    this.menuSaveFileAs.Enabled = true;
                }
                stream.Close();
            }
        }

        public void Save(LF f)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(ActiveMdiChild.Text, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, new SaveData(f.workSpace.Size, f.workSpace.lst));
            f.openedFlag = true;
            f.saveFlag = false;
            stream.Close();
        }

        public bool SaveAs(LF f)
        {
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            bool res = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, new SaveData(f.workSpace.Size, f.workSpace.lst));
                f.openedFlag = true;
                f.saveFlag = false;
                f.Text = saveFileDialog1.FileName;
                stream.Close();
                res = false;
            }
            return res;
        }
    }
}
