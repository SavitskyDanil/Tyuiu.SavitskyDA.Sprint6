using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SavitskyDA.Sprint6.Task1.V29.Lib;

namespace Tyuiu.SavitskyDA.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
           
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SDA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SDA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_SDA.Text = "";
                textBoxResult_SDA.AppendText("---------+--------------" + Environment.NewLine);
                textBoxResult_SDA.AppendText("|     X  |     f(x)    |" + Environment.NewLine);
                textBoxResult_SDA.AppendText("---------+--------------" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++ )
                {
                    strLine = String.Format("|{0,5:d}   |    {1,6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_SDA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SDA.AppendText("---------+--------------" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SDA_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-1 Савицкий Данил Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
