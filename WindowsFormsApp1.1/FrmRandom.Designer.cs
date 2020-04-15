namespace MyGUI._1
{
    partial class FrmRandom
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnRandomNo = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblRGB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnGenerate.Location = new System.Drawing.Point(47, 60);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(297, 62);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate Random Color";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnRandomNo
            // 
            this.BtnRandomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnRandomNo.Location = new System.Drawing.Point(47, 256);
            this.BtnRandomNo.Name = "BtnRandomNo";
            this.BtnRandomNo.Size = new System.Drawing.Size(141, 57);
            this.BtnRandomNo.TabIndex = 1;
            this.BtnRandomNo.Text = "Random Number";
            this.BtnRandomNo.UseVisualStyleBackColor = false;
            this.BtnRandomNo.Click += new System.EventHandler(this.BtnRandomNo_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.Location = new System.Drawing.Point(269, 343);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 33);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.Location = new System.Drawing.Point(154, 161);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(50, 20);
            this.lblRGB.TabIndex = 3;
            this.lblRGB.Text = "r-g-b";
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(435, 412);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRandomNo);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "FrmRandom";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnRandomNo;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label lblRGB;
    }
}