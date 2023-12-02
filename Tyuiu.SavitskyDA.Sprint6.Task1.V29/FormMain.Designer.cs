
namespace Tyuiu.SavitskyDA.Sprint6.Task1.V29
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
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_SDA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_SDA = new System.Windows.Forms.GroupBox();
            this.labelResult_SDA = new System.Windows.Forms.Label();
            this.textBoxStart_SDA = new System.Windows.Forms.TextBox();
            this.textBoxStop_SDA = new System.Windows.Forms.TextBox();
            this.labelStart_SDA = new System.Windows.Forms.Label();
            this.labelStop_SDA = new System.Windows.Forms.Label();
            this.buttonInfo_SDA = new System.Windows.Forms.Button();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SDA.SuspendLayout();
            this.groupBoxInfo_SDA.SuspendLayout();
            this.groupBoxResult_SDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 21);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(572, 254);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            this.groupBoxTask_SDA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SDA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(560, 128);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.TabStop = false;
            this.textBoxTask_SDA.Text = "Табулирование \" cos (x) / (x + 1 ) - cos(x) * 1,3 + 3x \" на заданном диапазоне [-" +
    "5; 5].";
            // 
            // groupBoxInfo_SDA
            // 
            this.groupBoxInfo_SDA.Controls.Add(this.labelStop_SDA);
            this.groupBoxInfo_SDA.Controls.Add(this.labelStart_SDA);
            this.groupBoxInfo_SDA.Controls.Add(this.textBoxStop_SDA);
            this.groupBoxInfo_SDA.Controls.Add(this.textBoxStart_SDA);
            this.groupBoxInfo_SDA.Location = new System.Drawing.Point(12, 297);
            this.groupBoxInfo_SDA.Name = "groupBoxInfo_SDA";
            this.groupBoxInfo_SDA.Size = new System.Drawing.Size(288, 80);
            this.groupBoxInfo_SDA.TabIndex = 1;
            this.groupBoxInfo_SDA.TabStop = false;
            this.groupBoxInfo_SDA.Text = "Ввод данных";
            // 
            // groupBoxResult_SDA
            // 
            this.groupBoxResult_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.labelResult_SDA);
            this.groupBoxResult_SDA.Location = new System.Drawing.Point(590, 21);
            this.groupBoxResult_SDA.Name = "groupBoxResult_SDA";
            this.groupBoxResult_SDA.Size = new System.Drawing.Size(278, 356);
            this.groupBoxResult_SDA.TabIndex = 2;
            this.groupBoxResult_SDA.TabStop = false;
            this.groupBoxResult_SDA.Text = "Вывод данных";
            // 
            // labelResult_SDA
            // 
            this.labelResult_SDA.AutoSize = true;
            this.labelResult_SDA.Location = new System.Drawing.Point(7, 25);
            this.labelResult_SDA.Name = "labelResult_SDA";
            this.labelResult_SDA.Size = new System.Drawing.Size(74, 15);
            this.labelResult_SDA.TabIndex = 0;
            this.labelResult_SDA.Text = "Результат: ";
            // 
            // textBoxStart_SDA
            // 
            this.textBoxStart_SDA.Location = new System.Drawing.Point(7, 44);
            this.textBoxStart_SDA.Name = "textBoxStart_SDA";
            this.textBoxStart_SDA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SDA.TabIndex = 0;
            // 
            // textBoxStop_SDA
            // 
            this.textBoxStop_SDA.Location = new System.Drawing.Point(158, 44);
            this.textBoxStop_SDA.Name = "textBoxStop_SDA";
            this.textBoxStop_SDA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SDA.TabIndex = 0;
            // 
            // labelStart_SDA
            // 
            this.labelStart_SDA.AutoSize = true;
            this.labelStart_SDA.Location = new System.Drawing.Point(6, 19);
            this.labelStart_SDA.Name = "labelStart_SDA";
            this.labelStart_SDA.Size = new System.Drawing.Size(77, 15);
            this.labelStart_SDA.TabIndex = 0;
            this.labelStart_SDA.Text = "Старт шага:";
            // 
            // labelStop_SDA
            // 
            this.labelStop_SDA.AutoSize = true;
            this.labelStop_SDA.Location = new System.Drawing.Point(155, 19);
            this.labelStop_SDA.Name = "labelStop_SDA";
            this.labelStop_SDA.Size = new System.Drawing.Size(77, 15);
            this.labelStop_SDA.TabIndex = 0;
            this.labelStop_SDA.Text = "Конец шага:";
            // 
            // buttonInfo_SDA
            // 
            this.buttonInfo_SDA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_SDA.Location = new System.Drawing.Point(343, 307);
            this.buttonInfo_SDA.Name = "buttonInfo_SDA";
            this.buttonInfo_SDA.Size = new System.Drawing.Size(88, 69);
            this.buttonInfo_SDA.TabIndex = 3;
            this.buttonInfo_SDA.Text = "Справка";
            this.buttonInfo_SDA.UseVisualStyleBackColor = false;
            this.buttonInfo_SDA.Click += new System.EventHandler(this.buttonInfo_SDA_Click);
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SDA.Location = new System.Drawing.Point(454, 307);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(124, 69);
            this.buttonDone_SDA.TabIndex = 3;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_SDA.Font = new System.Drawing.Font("Consolas", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SDA.Location = new System.Drawing.Point(8, 39);
            this.textBoxResult_SDA.Multiline = true;
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ReadOnly = true;
            this.textBoxResult_SDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(262, 307);
            this.textBoxResult_SDA.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 389);
            this.Controls.Add(this.buttonDone_SDA);
            this.Controls.Add(this.buttonInfo_SDA);
            this.Controls.Add(this.groupBoxResult_SDA);
            this.Controls.Add(this.groupBoxInfo_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 29 | Савицкий Д.А.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.groupBoxInfo_SDA.ResumeLayout(false);
            this.groupBoxInfo_SDA.PerformLayout();
            this.groupBoxResult_SDA.ResumeLayout(false);
            this.groupBoxResult_SDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.GroupBox groupBoxInfo_SDA;
        private System.Windows.Forms.Label labelStop_SDA;
        private System.Windows.Forms.Label labelStart_SDA;
        private System.Windows.Forms.TextBox textBoxStop_SDA;
        private System.Windows.Forms.TextBox textBoxStart_SDA;
        private System.Windows.Forms.GroupBox groupBoxResult_SDA;
        private System.Windows.Forms.Label labelResult_SDA;
        private System.Windows.Forms.Button buttonInfo_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
    }
}

