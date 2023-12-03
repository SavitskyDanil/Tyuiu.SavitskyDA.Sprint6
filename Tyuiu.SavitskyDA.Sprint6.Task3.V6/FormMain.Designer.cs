
namespace Tyuiu.SavitskyDA.Sprint6.Task3.V6
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SDA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SDA = new System.Windows.Forms.GroupBox();
            this.labelResult_SDA = new System.Windows.Forms.Label();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.buttonInfo_SDA = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewResult_SDA = new System.Windows.Forms.DataGridView();
            this.dataGridViewResultt_SDA = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SDA)).BeginInit();
            this.groupBoxResult_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultt_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.dataGridViewMatrix_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.dataGridViewResult_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(436, 265);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // dataGridViewMatrix_SDA
            // 
            this.dataGridViewMatrix_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SDA.Location = new System.Drawing.Point(190, 67);
            this.dataGridViewMatrix_SDA.Name = "dataGridViewMatrix_SDA";
            this.dataGridViewMatrix_SDA.ReadOnly = true;
            this.dataGridViewMatrix_SDA.RowHeadersVisible = false;
            this.dataGridViewMatrix_SDA.RowHeadersWidth = 51;
            this.dataGridViewMatrix_SDA.RowTemplate.Height = 24;
            this.dataGridViewMatrix_SDA.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMatrix_SDA.TabIndex = 1;
            this.dataGridViewMatrix_SDA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_SDA_CellContentClick);
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SDA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(18, 32);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(412, 197);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.TabStop = false;
            this.textBoxTask_SDA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в третьей строке на 0.\r\n\r\n " +
    " -2 -10  -8  11   1\r\n\r\n -15  -9  -4 -15  18\r\n\r\n -15  12   7   6   9\r\n\r\n -14 -10 " +
    " 10  18  -5\r\n\r\n  -1   7 -19 -19  -4\r\n";
            // 
            // groupBoxResult_SDA
            // 
            this.groupBoxResult_SDA.Controls.Add(this.dataGridViewResultt_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.buttonDone_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.buttonInfo_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.labelResult_SDA);
            this.groupBoxResult_SDA.Location = new System.Drawing.Point(454, 12);
            this.groupBoxResult_SDA.Name = "groupBoxResult_SDA";
            this.groupBoxResult_SDA.Size = new System.Drawing.Size(283, 265);
            this.groupBoxResult_SDA.TabIndex = 1;
            this.groupBoxResult_SDA.TabStop = false;
            this.groupBoxResult_SDA.Text = "Вывод данных";
            // 
            // labelResult_SDA
            // 
            this.labelResult_SDA.AutoSize = true;
            this.labelResult_SDA.Location = new System.Drawing.Point(23, 32);
            this.labelResult_SDA.Name = "labelResult_SDA";
            this.labelResult_SDA.Size = new System.Drawing.Size(84, 17);
            this.labelResult_SDA.TabIndex = 0;
            this.labelResult_SDA.Text = "Результат: ";
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.Location = new System.Drawing.Point(168, 223);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(98, 36);
            this.buttonDone_SDA.TabIndex = 2;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = true;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // buttonInfo_SDA
            // 
            this.buttonInfo_SDA.Location = new System.Drawing.Point(26, 223);
            this.buttonInfo_SDA.Name = "buttonInfo_SDA";
            this.buttonInfo_SDA.Size = new System.Drawing.Size(98, 36);
            this.buttonInfo_SDA.TabIndex = 3;
            this.buttonInfo_SDA.Text = "?";
            this.buttonInfo_SDA.UseVisualStyleBackColor = true;
            this.buttonInfo_SDA.Click += new System.EventHandler(this.buttonInfo_SDA_Click);
            // 
            // dataGridViewResult_SDA
            // 
            this.dataGridViewResult_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SDA.Location = new System.Drawing.Point(190, 67);
            this.dataGridViewResult_SDA.Name = "dataGridViewResult_SDA";
            this.dataGridViewResult_SDA.RowHeadersVisible = false;
            this.dataGridViewResult_SDA.RowHeadersWidth = 51;
            this.dataGridViewResult_SDA.RowTemplate.Height = 24;
            this.dataGridViewResult_SDA.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResult_SDA.TabIndex = 1;
            // 
            // dataGridViewResultt_SDA
            // 
            this.dataGridViewResultt_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultt_SDA.Location = new System.Drawing.Point(26, 67);
            this.dataGridViewResultt_SDA.Name = "dataGridViewResultt_SDA";
            this.dataGridViewResultt_SDA.ReadOnly = true;
            this.dataGridViewResultt_SDA.RowHeadersVisible = false;
            this.dataGridViewResultt_SDA.RowHeadersWidth = 51;
            this.dataGridViewResultt_SDA.RowTemplate.Height = 24;
            this.dataGridViewResultt_SDA.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResultt_SDA.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 294);
            this.Controls.Add(this.groupBoxResult_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 6 | Савицкий Д.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SDA)).EndInit();
            this.groupBoxResult_SDA.ResumeLayout(false);
            this.groupBoxResult_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultt_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.GroupBox groupBoxResult_SDA;
        private System.Windows.Forms.Label labelResult_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.Button buttonInfo_SDA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SDA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SDA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewResultt_SDA;
    }
}

