
namespace Tyuiu.SavitskyDA.Sprint6.Task0.V12
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
            this.groupBoxTask0_SDA = new System.Windows.Forms.GroupBox();
            this.groupBoxDannue_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.labelVarX_SDA = new System.Windows.Forms.Label();
            this.labelResult_SDA = new System.Windows.Forms.Label();
            this.buttonPushMe_SDA = new System.Windows.Forms.Button();
            this.buttonInfo_SDA = new System.Windows.Forms.Button();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_SDA = new System.Windows.Forms.PictureBox();
            this.groupBoxTask0_SDA.SuspendLayout();
            this.groupBoxDannue_SDA.SuspendLayout();
            this.groupBoxResult_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask0_SDA
            // 
            this.groupBoxTask0_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask0_SDA.Controls.Add(this.pictureBoxFormula_SDA);
            this.groupBoxTask0_SDA.Location = new System.Drawing.Point(14, 27);
            this.groupBoxTask0_SDA.Name = "groupBoxTask0_SDA";
            this.groupBoxTask0_SDA.Size = new System.Drawing.Size(462, 150);
            this.groupBoxTask0_SDA.TabIndex = 0;
            this.groupBoxTask0_SDA.TabStop = false;
            this.groupBoxTask0_SDA.Text = "Условие";
            // 
            // groupBoxDannue_SDA
            // 
            this.groupBoxDannue_SDA.Controls.Add(this.labelVarX_SDA);
            this.groupBoxDannue_SDA.Controls.Add(this.textBoxVarX_SDA);
            this.groupBoxDannue_SDA.Location = new System.Drawing.Point(14, 183);
            this.groupBoxDannue_SDA.Name = "groupBoxDannue_SDA";
            this.groupBoxDannue_SDA.Size = new System.Drawing.Size(292, 100);
            this.groupBoxDannue_SDA.TabIndex = 1;
            this.groupBoxDannue_SDA.TabStop = false;
            this.groupBoxDannue_SDA.Text = "Ввод данных";
            // 
            // textBoxVarX_SDA
            // 
            this.textBoxVarX_SDA.Location = new System.Drawing.Point(11, 50);
            this.textBoxVarX_SDA.Name = "textBoxVarX_SDA";
            this.textBoxVarX_SDA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_SDA.TabIndex = 0;
            this.textBoxVarX_SDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_SDA_KeyPress);
            // 
            // groupBoxResult_SDA
            // 
            this.groupBoxResult_SDA.Controls.Add(this.labelResult_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxResult_SDA.Location = new System.Drawing.Point(312, 183);
            this.groupBoxResult_SDA.Name = "groupBoxResult_SDA";
            this.groupBoxResult_SDA.Size = new System.Drawing.Size(164, 100);
            this.groupBoxResult_SDA.TabIndex = 2;
            this.groupBoxResult_SDA.TabStop = false;
            this.groupBoxResult_SDA.Text = "Вывод данных";
            this.groupBoxResult_SDA.Enter += new System.EventHandler(this.groupBoxResult_SDA_Enter);
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.Location = new System.Drawing.Point(12, 50);
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ReadOnly = true;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(141, 20);
            this.textBoxResult_SDA.TabIndex = 3;
            this.textBoxResult_SDA.TextChanged += new System.EventHandler(this.textBoxResult_SDA_TextChanged);
            // 
            // labelVarX_SDA
            // 
            this.labelVarX_SDA.AutoSize = true;
            this.labelVarX_SDA.Location = new System.Drawing.Point(8, 34);
            this.labelVarX_SDA.Name = "labelVarX_SDA";
            this.labelVarX_SDA.Size = new System.Drawing.Size(90, 13);
            this.labelVarX_SDA.TabIndex = 2;
            this.labelVarX_SDA.Text = "Переменная X : ";
            // 
            // labelResult_SDA
            // 
            this.labelResult_SDA.AutoSize = true;
            this.labelResult_SDA.Location = new System.Drawing.Point(9, 34);
            this.labelResult_SDA.Name = "labelResult_SDA";
            this.labelResult_SDA.Size = new System.Drawing.Size(65, 13);
            this.labelResult_SDA.TabIndex = 2;
            this.labelResult_SDA.Text = "Результат :";
            // 
            // buttonPushMe_SDA
            // 
            this.buttonPushMe_SDA.Location = new System.Drawing.Point(362, 289);
            this.buttonPushMe_SDA.Name = "buttonPushMe_SDA";
            this.buttonPushMe_SDA.Size = new System.Drawing.Size(114, 28);
            this.buttonPushMe_SDA.TabIndex = 3;
            this.buttonPushMe_SDA.Text = "Выполнить";
            this.buttonPushMe_SDA.UseVisualStyleBackColor = true;
            this.buttonPushMe_SDA.Click += new System.EventHandler(this.buttonPushMe_SDA_Click);
            // 
            // buttonInfo_SDA
            // 
            this.buttonInfo_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_SDA.Location = new System.Drawing.Point(312, 289);
            this.buttonInfo_SDA.Name = "buttonInfo_SDA";
            this.buttonInfo_SDA.Size = new System.Drawing.Size(33, 28);
            this.buttonInfo_SDA.TabIndex = 4;
            this.buttonInfo_SDA.Text = "?";
            this.buttonInfo_SDA.UseVisualStyleBackColor = true;
            this.buttonInfo_SDA.Click += new System.EventHandler(this.buttonInfo_SDA_Click);
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(11, 19);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(197, 125);
            this.textBoxTask_SDA.TabIndex = 2;
            this.textBoxTask_SDA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_SDA
            // 
            this.pictureBoxFormula_SDA.Image = global::Tyuiu.SavitskyDA.Sprint6.Task0.V12.Properties.Resources.Untitled;
            this.pictureBoxFormula_SDA.InitialImage = null;
            this.pictureBoxFormula_SDA.Location = new System.Drawing.Point(298, 19);
            this.pictureBoxFormula_SDA.Name = "pictureBoxFormula_SDA";
            this.pictureBoxFormula_SDA.Size = new System.Drawing.Size(141, 72);
            this.pictureBoxFormula_SDA.TabIndex = 1;
            this.pictureBoxFormula_SDA.TabStop = false;
            this.pictureBoxFormula_SDA.Click += new System.EventHandler(this.pictureBoxFormula_SDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 322);
            this.Controls.Add(this.buttonInfo_SDA);
            this.Controls.Add(this.buttonPushMe_SDA);
            this.Controls.Add(this.groupBoxResult_SDA);
            this.Controls.Add(this.groupBoxDannue_SDA);
            this.Controls.Add(this.groupBoxTask0_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 12 | Савицкий Д.А";
            this.groupBoxTask0_SDA.ResumeLayout(false);
            this.groupBoxTask0_SDA.PerformLayout();
            this.groupBoxDannue_SDA.ResumeLayout(false);
            this.groupBoxDannue_SDA.PerformLayout();
            this.groupBoxResult_SDA.ResumeLayout(false);
            this.groupBoxResult_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask0_SDA;
        private System.Windows.Forms.GroupBox groupBoxDannue_SDA;
        private System.Windows.Forms.Label labelVarX_SDA;
        private System.Windows.Forms.TextBox textBoxVarX_SDA;
        private System.Windows.Forms.GroupBox groupBoxResult_SDA;
        private System.Windows.Forms.Label labelResult_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
        private System.Windows.Forms.Button buttonPushMe_SDA;
        private System.Windows.Forms.Button buttonInfo_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SDA;
    }
}

