using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SavitskyDA.Sprint6.Task3.V6.Lib;

namespace Tyuiu.SavitskyDA.Sprint6.Task3.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
              { {-2,-10,-8,11,1},
                {-15,-9,-4,-15,18},
                {-15,12,7,6,9},
                {-14,-10,10,18,-5},
                {-1,7,-19,-19,-4} };
        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[,] res = ds.Calculate(matrix);

            dataGridViewResultt_SDA.ColumnCount = columns;
            dataGridViewResultt_SDA.RowCount = rows;

            for (int j = 0; j < columns; j++)
            {
                dataGridViewResultt_SDA.Columns[j].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResultt_SDA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }

        }

        private void buttonInfo_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-1 Савицкий Данил Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SDA.ColumnCount = columns;
            dataGridViewMatrix_SDA.RowCount = rows;

            for (int j = 0; j < columns; j++)
            {
                dataGridViewMatrix_SDA.Columns[j].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SDA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }

        private void dataGridViewMatrix_SDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
