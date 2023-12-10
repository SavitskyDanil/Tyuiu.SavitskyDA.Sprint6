
namespace Tyuiu.SavitskyDA.Sprint6.Task7.V16
{
    partial class FormAbout_SDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SDA));
            this.pictureBoxAvatar_SDA = new System.Windows.Forms.PictureBox();
            this.labelInfo_SDA = new System.Windows.Forms.Label();
            this.buttonOk_SDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_SDA
            // 
            this.pictureBoxAvatar_SDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SDA.Image")));
            this.pictureBoxAvatar_SDA.Location = new System.Drawing.Point(59, 27);
            this.pictureBoxAvatar_SDA.Name = "pictureBoxAvatar_SDA";
            this.pictureBoxAvatar_SDA.Size = new System.Drawing.Size(204, 217);
            this.pictureBoxAvatar_SDA.TabIndex = 0;
            this.pictureBoxAvatar_SDA.TabStop = false;
            // 
            // labelInfo_SDA
            // 
            this.labelInfo_SDA.AutoSize = true;
            this.labelInfo_SDA.Location = new System.Drawing.Point(269, 27);
            this.labelInfo_SDA.Name = "labelInfo_SDA";
            this.labelInfo_SDA.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_SDA.TabIndex = 1;
            this.labelInfo_SDA.Text = resources.GetString("labelInfo_SDA.Text");
            // 
            // buttonOk_SDA
            // 
            this.buttonOk_SDA.Location = new System.Drawing.Point(272, 183);
            this.buttonOk_SDA.Name = "buttonOk_SDA";
            this.buttonOk_SDA.Size = new System.Drawing.Size(360, 61);
            this.buttonOk_SDA.TabIndex = 3;
            this.buttonOk_SDA.Text = "Ок";
            this.buttonOk_SDA.UseVisualStyleBackColor = true;
            this.buttonOk_SDA.Click += new System.EventHandler(this.buttonOk_SDA_Click);
            // 
            // FormAbout_SDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(668, 270);
            this.Controls.Add(this.buttonOk_SDA);
            this.Controls.Add(this.labelInfo_SDA);
            this.Controls.Add(this.pictureBoxAvatar_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_SDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_SDA;
        private System.Windows.Forms.Label labelInfo_SDA;
        private System.Windows.Forms.Button buttonOk_SDA;
    }
}