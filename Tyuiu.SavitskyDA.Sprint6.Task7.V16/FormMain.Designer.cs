
namespace Tyuiu.SavitskyDA.Sprint6.Task7.V16
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTask_SDA = new System.Windows.Forms.Panel();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.buttonSave_SDA = new System.Windows.Forms.Button();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SDA = new System.Windows.Forms.Button();
            this.panelButton_SDA = new System.Windows.Forms.Panel();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.panelInfo_SDA = new System.Windows.Forms.Panel();
            this.groupBoxInfo_SDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_SDA = new System.Windows.Forms.DataGridView();
            this.splitterLeft_SDA = new System.Windows.Forms.Splitter();
            this.panelResult_SDA = new System.Windows.Forms.Panel();
            this.groupBoxResult_SDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_SDA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_SDA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_SDA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_SDA = new System.Windows.Forms.ToolTip(this.components);
            this.panelTask_SDA.SuspendLayout();
            this.panelButton_SDA.SuspendLayout();
            this.groupBoxTask_SDA.SuspendLayout();
            this.panelInfo_SDA.SuspendLayout();
            this.groupBoxInfo_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SDA)).BeginInit();
            this.panelResult_SDA.SuspendLayout();
            this.groupBoxResult_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_SDA
            // 
            this.panelTask_SDA.Controls.Add(this.buttonHelp_SDA);
            this.panelTask_SDA.Controls.Add(this.buttonSave_SDA);
            this.panelTask_SDA.Controls.Add(this.buttonDone_SDA);
            this.panelTask_SDA.Controls.Add(this.buttonOpenFile_SDA);
            this.panelTask_SDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_SDA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_SDA.Name = "panelTask_SDA";
            this.panelTask_SDA.Padding = new System.Windows.Forms.Padding(3);
            this.panelTask_SDA.Size = new System.Drawing.Size(1087, 84);
            this.panelTask_SDA.TabIndex = 0;
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SDA.Image")));
            this.buttonHelp_SDA.Location = new System.Drawing.Point(990, 12);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(85, 57);
            this.buttonHelp_SDA.TabIndex = 0;
            this.toolTipButton_SDA.SetToolTip(this.buttonHelp_SDA, "Сведения о программе");
            this.buttonHelp_SDA.UseVisualStyleBackColor = true;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            this.buttonHelp_SDA.MouseEnter += new System.EventHandler(this.buttonHelp_SDA_MouseEnter);
            // 
            // buttonSave_SDA
            // 
            this.buttonSave_SDA.Enabled = false;
            this.buttonSave_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SDA.Image")));
            this.buttonSave_SDA.Location = new System.Drawing.Point(185, 12);
            this.buttonSave_SDA.Name = "buttonSave_SDA";
            this.buttonSave_SDA.Size = new System.Drawing.Size(82, 57);
            this.buttonSave_SDA.TabIndex = 0;
            this.toolTipButton_SDA.SetToolTip(this.buttonSave_SDA, "Сохранить обработанные данные в файле в формате CSV");
            this.buttonSave_SDA.UseVisualStyleBackColor = true;
            this.buttonSave_SDA.Click += new System.EventHandler(this.buttonSave_SDA_Click);
            this.buttonSave_SDA.MouseEnter += new System.EventHandler(this.buttonSave_SDA_MouseEnter);
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.Enabled = false;
            this.buttonDone_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SDA.Image")));
            this.buttonDone_SDA.Location = new System.Drawing.Point(101, 12);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(78, 57);
            this.buttonDone_SDA.TabIndex = 0;
            this.toolTipButton_SDA.SetToolTip(this.buttonDone_SDA, "Выполнить обработку данных");
            this.buttonDone_SDA.UseVisualStyleBackColor = true;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            this.buttonDone_SDA.MouseEnter += new System.EventHandler(this.buttonDone_SDA_MouseEnter);
            // 
            // buttonOpenFile_SDA
            // 
            this.buttonOpenFile_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_SDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SDA.Image")));
            this.buttonOpenFile_SDA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SDA.Name = "buttonOpenFile_SDA";
            this.buttonOpenFile_SDA.Size = new System.Drawing.Size(83, 57);
            this.buttonOpenFile_SDA.TabIndex = 0;
            this.toolTipButton_SDA.SetToolTip(this.buttonOpenFile_SDA, "Открыть файл для обработки данных в формате CSV\r\n");
            this.buttonOpenFile_SDA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SDA.Click += new System.EventHandler(this.buttonOpenFile_SDA_Click);
            this.buttonOpenFile_SDA.MouseEnter += new System.EventHandler(this.buttonOpenFile_SDA_MouseEnter);
            // 
            // panelButton_SDA
            // 
            this.panelButton_SDA.Controls.Add(this.groupBoxTask_SDA);
            this.panelButton_SDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton_SDA.Location = new System.Drawing.Point(0, 84);
            this.panelButton_SDA.Name = "panelButton_SDA";
            this.panelButton_SDA.Padding = new System.Windows.Forms.Padding(3);
            this.panelButton_SDA.Size = new System.Drawing.Size(1087, 100);
            this.panelButton_SDA.TabIndex = 0;
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(1081, 94);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие:";
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(1075, 73);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.Text = resources.GetString("textBoxTask_SDA.Text");
            // 
            // panelInfo_SDA
            // 
            this.panelInfo_SDA.Controls.Add(this.groupBoxInfo_SDA);
            this.panelInfo_SDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInfo_SDA.Location = new System.Drawing.Point(0, 184);
            this.panelInfo_SDA.Name = "panelInfo_SDA";
            this.panelInfo_SDA.Padding = new System.Windows.Forms.Padding(3);
            this.panelInfo_SDA.Size = new System.Drawing.Size(478, 396);
            this.panelInfo_SDA.TabIndex = 0;
            // 
            // groupBoxInfo_SDA
            // 
            this.groupBoxInfo_SDA.Controls.Add(this.dataGridViewIn_SDA);
            this.groupBoxInfo_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfo_SDA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInfo_SDA.Name = "groupBoxInfo_SDA";
            this.groupBoxInfo_SDA.Size = new System.Drawing.Size(472, 390);
            this.groupBoxInfo_SDA.TabIndex = 0;
            this.groupBoxInfo_SDA.TabStop = false;
            this.groupBoxInfo_SDA.Text = "Ввод:";
            // 
            // dataGridViewIn_SDA
            // 
            this.dataGridViewIn_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_SDA.ColumnHeadersVisible = false;
            this.dataGridViewIn_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_SDA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_SDA.Name = "dataGridViewIn_SDA";
            this.dataGridViewIn_SDA.RowHeadersVisible = false;
            this.dataGridViewIn_SDA.RowHeadersWidth = 51;
            this.dataGridViewIn_SDA.RowTemplate.Height = 24;
            this.dataGridViewIn_SDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewIn_SDA.Size = new System.Drawing.Size(466, 369);
            this.dataGridViewIn_SDA.TabIndex = 0;
            // 
            // splitterLeft_SDA
            // 
            this.splitterLeft_SDA.Location = new System.Drawing.Point(478, 184);
            this.splitterLeft_SDA.Name = "splitterLeft_SDA";
            this.splitterLeft_SDA.Size = new System.Drawing.Size(3, 396);
            this.splitterLeft_SDA.TabIndex = 1;
            this.splitterLeft_SDA.TabStop = false;
            // 
            // panelResult_SDA
            // 
            this.panelResult_SDA.Controls.Add(this.groupBoxResult_SDA);
            this.panelResult_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_SDA.Location = new System.Drawing.Point(481, 184);
            this.panelResult_SDA.Name = "panelResult_SDA";
            this.panelResult_SDA.Size = new System.Drawing.Size(606, 396);
            this.panelResult_SDA.TabIndex = 2;
            // 
            // groupBoxResult_SDA
            // 
            this.groupBoxResult_SDA.Controls.Add(this.dataGridViewOut_SDA);
            this.groupBoxResult_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SDA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SDA.Name = "groupBoxResult_SDA";
            this.groupBoxResult_SDA.Size = new System.Drawing.Size(606, 396);
            this.groupBoxResult_SDA.TabIndex = 0;
            this.groupBoxResult_SDA.TabStop = false;
            this.groupBoxResult_SDA.Text = "Вывод:";
            // 
            // dataGridViewOut_SDA
            // 
            this.dataGridViewOut_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_SDA.ColumnHeadersVisible = false;
            this.dataGridViewOut_SDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_SDA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_SDA.Name = "dataGridViewOut_SDA";
            this.dataGridViewOut_SDA.RowHeadersVisible = false;
            this.dataGridViewOut_SDA.RowHeadersWidth = 51;
            this.dataGridViewOut_SDA.RowTemplate.Height = 24;
            this.dataGridViewOut_SDA.Size = new System.Drawing.Size(600, 375);
            this.dataGridViewOut_SDA.TabIndex = 0;
            // 
            // openFileDialogTask_SDA
            // 
            this.openFileDialogTask_SDA.FileName = "openFileDialog1";
            // 
            // toolTipButton_SDA
            // 
            this.toolTipButton_SDA.IsBalloon = true;
            this.toolTipButton_SDA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SDA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 580);
            this.Controls.Add(this.panelResult_SDA);
            this.Controls.Add(this.splitterLeft_SDA);
            this.Controls.Add(this.panelInfo_SDA);
            this.Controls.Add(this.panelButton_SDA);
            this.Controls.Add(this.panelTask_SDA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 16 | Савицкий Д.А.";
            this.panelTask_SDA.ResumeLayout(false);
            this.panelButton_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.panelInfo_SDA.ResumeLayout(false);
            this.groupBoxInfo_SDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SDA)).EndInit();
            this.panelResult_SDA.ResumeLayout(false);
            this.groupBoxResult_SDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_SDA;
        private System.Windows.Forms.Panel panelButton_SDA;
        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.Button buttonSave_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.Button buttonOpenFile_SDA;
        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.Panel panelInfo_SDA;
        private System.Windows.Forms.GroupBox groupBoxInfo_SDA;
        private System.Windows.Forms.Splitter splitterLeft_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.Panel panelResult_SDA;
        private System.Windows.Forms.GroupBox groupBoxResult_SDA;
        private System.Windows.Forms.ToolTip toolTipButton_SDA;
        private System.Windows.Forms.DataGridView dataGridViewIn_SDA;
        private System.Windows.Forms.DataGridView dataGridViewOut_SDA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SDA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SDA;
    }
}

