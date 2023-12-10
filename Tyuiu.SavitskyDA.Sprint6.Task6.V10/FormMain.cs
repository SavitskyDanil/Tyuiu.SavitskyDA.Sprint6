using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.SavitskyDA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.SavitskyDA.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFileDialogPath;
        DataService ds = new DataService();
        private void buttonOpenFile_SDA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SDA.ShowDialog();
            openFileDialogPath = openFileDialogTask_SDA.FileName;
            textBoxIn_SDA.Text = File.ReadAllText(openFileDialogPath);
            groupBoxInfo_SDA.Text = groupBoxInfo_SDA.Text + " " + openFileDialogTask_SDA.FileName;
            buttonDone_SDA.Enabled = true;
        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            textBoxOut_SDA.Text = ds.CollectTextFromFile(openFileDialogPath);
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void openFileDialogTask_SDA_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void groupBoxResult_SDA_Enter(object sender, EventArgs e)
        {

        }
    }
}
