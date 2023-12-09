
namespace Tyuiu.SavitskyDA.Sprint6.Task4.V24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTop_SDA = new System.Windows.Forms.Panel();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.buttonSave_SDA = new System.Windows.Forms.Button();
            this.buttonInfo_SDA = new System.Windows.Forms.Button();
            this.groupBoxResult_SDA = new System.Windows.Forms.GroupBox();
            this.labelStop_SDA = new System.Windows.Forms.Label();
            this.labelStart_SDA = new System.Windows.Forms.Label();
            this.textBoxStop_SDA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SDA = new System.Windows.Forms.TextBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.panelLeft_SDA = new System.Windows.Forms.Panel();
            this.groupBoxLeft_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.panelFill_SDA = new System.Windows.Forms.Panel();
            this.chartFunction_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterLeft_SDA = new System.Windows.Forms.Splitter();
            this.panelTop_SDA.SuspendLayout();
            this.groupBoxTask_SDA.SuspendLayout();
            this.groupBoxResult_SDA.SuspendLayout();
            this.panelLeft_SDA.SuspendLayout();
            this.groupBoxLeft_SDA.SuspendLayout();
            this.panelFill_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_SDA
            // 
            this.panelTop_SDA.Controls.Add(this.groupBoxTask_SDA);
            this.panelTop_SDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SDA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SDA.Name = "panelTop_SDA";
            this.panelTop_SDA.Size = new System.Drawing.Size(1191, 135);
            this.panelTop_SDA.TabIndex = 0;
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.buttonDone_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.buttonSave_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.buttonInfo_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.groupBoxResult_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(1191, 115);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие: ";
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SDA.Location = new System.Drawing.Point(864, 21);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(93, 70);
            this.buttonDone_SDA.TabIndex = 5;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // buttonSave_SDA
            // 
            this.buttonSave_SDA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_SDA.Location = new System.Drawing.Point(963, 21);
            this.buttonSave_SDA.Name = "buttonSave_SDA";
            this.buttonSave_SDA.Size = new System.Drawing.Size(88, 70);
            this.buttonSave_SDA.TabIndex = 6;
            this.buttonSave_SDA.Text = "Сохранить";
            this.buttonSave_SDA.UseVisualStyleBackColor = false;
            this.buttonSave_SDA.Click += new System.EventHandler(this.buttonSave_SDA_Click);
            // 
            // buttonInfo_SDA
            // 
            this.buttonInfo_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SDA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_SDA.Location = new System.Drawing.Point(1064, 21);
            this.buttonInfo_SDA.Name = "buttonInfo_SDA";
            this.buttonInfo_SDA.Size = new System.Drawing.Size(88, 70);
            this.buttonInfo_SDA.TabIndex = 4;
            this.buttonInfo_SDA.Text = "Справка";
            this.buttonInfo_SDA.UseVisualStyleBackColor = false;
            this.buttonInfo_SDA.Click += new System.EventHandler(this.buttonInfo_SDA_Click);
            // 
            // groupBoxResult_SDA
            // 
            this.groupBoxResult_SDA.Controls.Add(this.labelStop_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.labelStart_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.textBoxStop_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.textBoxStart_SDA);
            this.groupBoxResult_SDA.Location = new System.Drawing.Point(616, 12);
            this.groupBoxResult_SDA.Name = "groupBoxResult_SDA";
            this.groupBoxResult_SDA.Size = new System.Drawing.Size(242, 79);
            this.groupBoxResult_SDA.TabIndex = 3;
            this.groupBoxResult_SDA.TabStop = false;
            this.groupBoxResult_SDA.Text = "Вывод данных: ";
            // 
            // labelStop_SDA
            // 
            this.labelStop_SDA.AutoSize = true;
            this.labelStop_SDA.Location = new System.Drawing.Point(125, 18);
            this.labelStop_SDA.Name = "labelStop_SDA";
            this.labelStop_SDA.Size = new System.Drawing.Size(89, 17);
            this.labelStop_SDA.TabIndex = 1;
            this.labelStop_SDA.Text = "Конец шага:";
            // 
            // labelStart_SDA
            // 
            this.labelStart_SDA.AutoSize = true;
            this.labelStart_SDA.Location = new System.Drawing.Point(6, 18);
            this.labelStart_SDA.Name = "labelStart_SDA";
            this.labelStart_SDA.Size = new System.Drawing.Size(87, 17);
            this.labelStart_SDA.TabIndex = 1;
            this.labelStart_SDA.Text = "Старт шага:";
            // 
            // textBoxStop_SDA
            // 
            this.textBoxStop_SDA.Location = new System.Drawing.Point(128, 42);
            this.textBoxStop_SDA.Name = "textBoxStop_SDA";
            this.textBoxStop_SDA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_SDA.TabIndex = 0;
            // 
            // textBoxStart_SDA
            // 
            this.textBoxStart_SDA.Location = new System.Drawing.Point(9, 42);
            this.textBoxStart_SDA.Name = "textBoxStart_SDA";
            this.textBoxStart_SDA.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_SDA.TabIndex = 0;
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(8, 21);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(602, 70);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.Text = resources.GetString("textBoxTask_SDA.Text");
            // 
            // panelLeft_SDA
            // 
            this.panelLeft_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft_SDA.Controls.Add(this.groupBoxLeft_SDA);
            this.panelLeft_SDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SDA.Location = new System.Drawing.Point(0, 135);
            this.panelLeft_SDA.Name = "panelLeft_SDA";
            this.panelLeft_SDA.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_SDA.Size = new System.Drawing.Size(213, 380);
            this.panelLeft_SDA.TabIndex = 1;
            // 
            // groupBoxLeft_SDA
            // 
            this.groupBoxLeft_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLeft_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxLeft_SDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLeft_SDA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxLeft_SDA.Name = "groupBoxLeft_SDA";
            this.groupBoxLeft_SDA.Size = new System.Drawing.Size(200, 370);
            this.groupBoxLeft_SDA.TabIndex = 0;
            this.groupBoxLeft_SDA.TabStop = false;
            this.groupBoxLeft_SDA.Text = "Вывод:";
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SDA.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_SDA.Multiline = true;
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(194, 349);
            this.textBoxResult_SDA.TabIndex = 0;
            // 
            // panelFill_SDA
            // 
            this.panelFill_SDA.Controls.Add(this.chartFunction_SDA);
            this.panelFill_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SDA.Location = new System.Drawing.Point(213, 135);
            this.panelFill_SDA.Name = "panelFill_SDA";
            this.panelFill_SDA.Size = new System.Drawing.Size(978, 380);
            this.panelFill_SDA.TabIndex = 1;
            // 
            // chartFunction_SDA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SDA.ChartAreas.Add(chartArea1);
            this.chartFunction_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_SDA.Legends.Add(legend1);
            this.chartFunction_SDA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_SDA.Name = "chartFunction_SDA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SDA.Series.Add(series1);
            this.chartFunction_SDA.Size = new System.Drawing.Size(978, 380);
            this.chartFunction_SDA.TabIndex = 0;
            this.chartFunction_SDA.Text = "chart1";
            title1.Name = "TitleFormula";
            title1.Text = "График функции sin(x) / (x + 1.2) - sin(x) * 2 - 2 * x";
            this.chartFunction_SDA.Titles.Add(title1);
            // 
            // splitterLeft_SDA
            // 
            this.splitterLeft_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.splitterLeft_SDA.Location = new System.Drawing.Point(213, 135);
            this.splitterLeft_SDA.Name = "splitterLeft_SDA";
            this.splitterLeft_SDA.Size = new System.Drawing.Size(3, 380);
            this.splitterLeft_SDA.TabIndex = 2;
            this.splitterLeft_SDA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 515);
            this.Controls.Add(this.splitterLeft_SDA);
            this.Controls.Add(this.panelFill_SDA);
            this.Controls.Add(this.panelLeft_SDA);
            this.Controls.Add(this.panelTop_SDA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.groupBoxResult_SDA.ResumeLayout(false);
            this.groupBoxResult_SDA.PerformLayout();
            this.panelLeft_SDA.ResumeLayout(false);
            this.groupBoxLeft_SDA.ResumeLayout(false);
            this.groupBoxLeft_SDA.PerformLayout();
            this.panelFill_SDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SDA;
        private System.Windows.Forms.Panel panelLeft_SDA;
        private System.Windows.Forms.Panel panelFill_SDA;
        private System.Windows.Forms.Splitter splitterLeft_SDA;
        private System.Windows.Forms.GroupBox groupBoxLeft_SDA;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.Button buttonSave_SDA;
        private System.Windows.Forms.Button buttonInfo_SDA;
        private System.Windows.Forms.GroupBox groupBoxResult_SDA;
        private System.Windows.Forms.Label labelStop_SDA;
        private System.Windows.Forms.Label labelStart_SDA;
        private System.Windows.Forms.TextBox textBoxStop_SDA;
        private System.Windows.Forms.TextBox textBoxStart_SDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SDA;
    }
}

