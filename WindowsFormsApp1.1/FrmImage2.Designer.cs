namespace WindowsFormsApp1._1
{
    partial class FrmImage2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.btnPicFile = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Location = new System.Drawing.Point(189, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 369);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // picTry
            // 
            this.picTry.Location = new System.Drawing.Point(7, 45);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(269, 309);
            this.picTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTry.TabIndex = 4;
            this.picTry.TabStop = false;
            // 
            // btnPicFile
            // 
            this.btnPicFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPicFile.Location = new System.Drawing.Point(21, 77);
            this.btnPicFile.Name = "btnPicFile";
            this.btnPicFile.Size = new System.Drawing.Size(135, 55);
            this.btnPicFile.TabIndex = 6;
            this.btnPicFile.Text = "Load Image";
            this.btnPicFile.UseVisualStyleBackColor = false;
            this.btnPicFile.Click += new System.EventHandler(this.btnPicFile_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnExit.Location = new System.Drawing.Point(330, 422);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(135, 55);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmImage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(487, 489);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnPicFile);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmImage2";
            this.Text = "Image2";
            this.Load += new System.EventHandler(this.FrmImage2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picTry;
        private System.Windows.Forms.Button btnPicFile;
        private System.Windows.Forms.Button BtnExit;
    }
}