using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SavitskyDA.Sprint6.Task5.V28.Lib;

namespace Tyuiu.SavitskyDA.Sprint6.Task5.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V28.txt";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SDA.ColumnCount = 2;
            dataGridViewResult_SDA.Columns[0].Width = 50;
            dataGridViewResult_SDA.Columns[1].Width = 80;

            this.chartDiag_SDA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SDA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_SDA.Series[0].Points.Clear(); 

            double[] numsMass = new double [ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_SDA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SDA.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void buttonOpen_SDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-1 Савицкий Данил Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartDiag_SDA_Click(object sender, EventArgs e)
        {

        }
    }
}
