
namespace Tyuiu.SavitskyDA.Sprint6.Task5.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_SDA = new System.Windows.Forms.Panel();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.buttonOpen_SDA = new System.Windows.Forms.Button();
            this.buttonInfo_SDA = new System.Windows.Forms.Button();
            this.panelLeft_SDA = new System.Windows.Forms.Panel();
            this.panelFill_SDA = new System.Windows.Forms.Panel();
            this.groupBoxResult_SDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SDA = new System.Windows.Forms.DataGridView();
            this.splitterLeft_SDA = new System.Windows.Forms.Splitter();
            this.chartDiag_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_SDA.SuspendLayout();
            this.groupBoxTask_SDA.SuspendLayout();
            this.panelLeft_SDA.SuspendLayout();
            this.panelFill_SDA.SuspendLayout();
            this.groupBoxResult_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_SDA
            // 
            this.panelTop_SDA.Controls.Add(this.buttonInfo_SDA);
            this.panelTop_SDA.Controls.Add(this.buttonOpen_SDA);
            this.panelTop_SDA.Controls.Add(this.buttonDone_SDA);
            this.panelTop_SDA.Controls.Add(this.groupBoxTask_SDA);
            this.panelTop_SDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SDA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SDA.Name = "panelTop_SDA";
            this.panelTop_SDA.Size = new System.Drawing.Size(906, 106);
            this.panelTop_SDA.TabIndex = 0;
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(574, 85);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие :";
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(562, 54);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.Text = "Прочитать данные из файла InPutFileTask5V28.txt. \r\nВывести в dataGridView все чис" +
    "ла, меньше 10 и построить диаграмму по этим значениям.";
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SDA.Location = new System.Drawing.Point(592, 33);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(98, 54);
            this.buttonDone_SDA.TabIndex = 1;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // buttonOpen_SDA
            // 
            this.buttonOpen_SDA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_SDA.Location = new System.Drawing.Point(696, 33);
            this.buttonOpen_SDA.Name = "buttonOpen_SDA";
            this.buttonOpen_SDA.Size = new System.Drawing.Size(117, 54);
            this.buttonOpen_SDA.TabIndex = 1;
            this.buttonOpen_SDA.Text = "Открыть файл";
            this.buttonOpen_SDA.UseVisualStyleBackColor = false;
            this.buttonOpen_SDA.Click += new System.EventHandler(this.buttonOpen_SDA_Click);
            // 
            // buttonInfo_SDA
            // 
            this.buttonInfo_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SDA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonInfo_SDA.Location = new System.Drawing.Point(819, 33);
            this.buttonInfo_SDA.Name = "buttonInfo_SDA";
            this.buttonInfo_SDA.Size = new System.Drawing.Size(75, 54);
            this.buttonInfo_SDA.TabIndex = 1;
            this.buttonInfo_SDA.Text = "Справка";
            this.buttonInfo_SDA.UseVisualStyleBackColor = false;
            this.buttonInfo_SDA.Click += new System.EventHandler(this.buttonInfo_SDA_Click);
            // 
            // panelLeft_SDA
            // 
            this.panelLeft_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft_SDA.Controls.Add(this.groupBoxResult_SDA);
            this.panelLeft_SDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SDA.Location = new System.Drawing.Point(0, 106);
            this.panelLeft_SDA.Name = "panelLeft_SDA";
            this.panelLeft_SDA.Size = new System.Drawing.Size(200, 406);
            this.panelLeft_SDA.TabIndex = 1;
            // 
            // panelFill_SDA
            // 
            this.panelFill_SDA.BackColor = System.Drawing.Color.White;
            this.panelFill_SDA.Controls.Add(this.chartDiag_SDA);
            this.panelFill_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SDA.Location = new System.Drawing.Point(200, 106);
            this.panelFill_SDA.Name = "panelFill_SDA";
            this.panelFill_SDA.Size = new System.Drawing.Size(706, 406);
            this.panelFill_SDA.TabIndex = 1;
            // 
            // groupBoxResult_SDA
            // 
            this.groupBoxResult_SDA.Controls.Add(this.dataGridViewResult_SDA);
            this.groupBoxResult_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SDA.Name = "groupBoxResult_SDA";
            this.groupBoxResult_SDA.Size = new System.Drawing.Size(200, 406);
            this.groupBoxResult_SDA.TabIndex = 0;
            this.groupBoxResult_SDA.TabStop = false;
            this.groupBoxResult_SDA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_SDA
            // 
            this.dataGridViewResult_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SDA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_SDA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewResult_SDA.Name = "dataGridViewResult_SDA";
            this.dataGridViewResult_SDA.ReadOnly = true;
            this.dataGridViewResult_SDA.RowHeadersVisible = false;
            this.dataGridViewResult_SDA.RowHeadersWidth = 51;
            this.dataGridViewResult_SDA.RowTemplate.Height = 24;
            this.dataGridViewResult_SDA.Size = new System.Drawing.Size(194, 385);
            this.dataGridViewResult_SDA.TabIndex = 0;
            // 
            // splitterLeft_SDA
            // 
            this.splitterLeft_SDA.Location = new System.Drawing.Point(200, 106);
            this.splitterLeft_SDA.Name = "splitterLeft_SDA";
            this.splitterLeft_SDA.Size = new System.Drawing.Size(3, 406);
            this.splitterLeft_SDA.TabIndex = 2;
            this.splitterLeft_SDA.TabStop = false;
            // 
            // chartDiag_SDA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_SDA.ChartAreas.Add(chartArea2);
            this.chartDiag_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiag_SDA.Legends.Add(legend2);
            this.chartDiag_SDA.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_SDA.Name = "chartDiag_SDA";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiag_SDA.Series.Add(series2);
            this.chartDiag_SDA.Size = new System.Drawing.Size(706, 406);
            this.chartDiag_SDA.TabIndex = 0;
            this.chartDiag_SDA.Text = "chart1";
            this.chartDiag_SDA.Click += new System.EventHandler(this.chartDiag_SDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 512);
            this.Controls.Add(this.splitterLeft_SDA);
            this.Controls.Add(this.panelFill_SDA);
            this.Controls.Add(this.panelLeft_SDA);
            this.Controls.Add(this.panelTop_SDA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 |  Вариант 28 | Савицкий Д.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.panelLeft_SDA.ResumeLayout(false);
            this.panelFill_SDA.ResumeLayout(false);
            this.groupBoxResult_SDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SDA;
        private System.Windows.Forms.Button buttonInfo_SDA;
        private System.Windows.Forms.Button buttonOpen_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.Panel panelLeft_SDA;
        private System.Windows.Forms.Panel panelFill_SDA;
        private System.Windows.Forms.GroupBox groupBoxResult_SDA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SDA;
        private System.Windows.Forms.Splitter splitterLeft_SDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SDA;
    }
}

