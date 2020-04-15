namespace MyGUI
{
    partial class FrmImage
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
            this.btnPicFile = new System.Windows.Forms.Button();
            this.btnPicRes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picTry2 = new System.Windows.Forms.PictureBox();
            this.picTry = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPicFile
            // 
            this.btnPicFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPicFile.Location = new System.Drawing.Point(12, 67);
            this.btnPicFile.Name = "btnPicFile";
            this.btnPicFile.Size = new System.Drawing.Size(135, 55);
            this.btnPicFile.TabIndex = 0;
            this.btnPicFile.Text = "Image from File";
            this.btnPicFile.UseVisualStyleBackColor = false;
            this.btnPicFile.Click += new System.EventHandler(this.btnPicFile_Click);
            // 
            // btnPicRes
            // 
            this.btnPicRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPicRes.Location = new System.Drawing.Point(12, 128);
            this.btnPicRes.Name = "btnPicRes";
            this.btnPicRes.Size = new System.Drawing.Size(135, 55);
            this.btnPicRes.TabIndex = 0;
            this.btnPicRes.Text = "Image from resource";
            this.btnPicRes.UseVisualStyleBackColor = false;
            this.btnPicRes.Click += new System.EventHandler(this.btnPicRes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picTry2);
            this.groupBox1.Controls.Add(this.picTry);
            this.groupBox1.Location = new System.Drawing.Point(175, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 385);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture Boxes";
            // 
            // picTry2
            // 
            this.picTry2.Location = new System.Drawing.Point(292, 45);
            this.picTry2.Name = "picTry2";
            this.picTry2.Size = new System.Drawing.Size(269, 309);
            this.picTry2.TabIndex = 3;
            this.picTry2.TabStop = false;
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
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPicRes);
            this.Controls.Add(this.btnPicFile);
            this.Name = "FrmImage";
            this.Text = "Image1";
            this.Load += new System.EventHandler(this.FrmImage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTry2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPicFile;
        private System.Windows.Forms.Button btnPicRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picTry2;
        private System.Windows.Forms.PictureBox picTry;
    }
}