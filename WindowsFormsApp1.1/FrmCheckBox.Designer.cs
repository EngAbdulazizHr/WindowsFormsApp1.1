namespace MyGUI._1
{
    partial class FrmCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckBox));
            this.BtnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkBrownie = new System.Windows.Forms.CheckBox();
            this.ChkDount = new System.Windows.Forms.CheckBox();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnShow.Location = new System.Drawing.Point(35, 38);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(104, 42);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkBrownie);
            this.groupBox1.Controls.Add(this.ChkDount);
            this.groupBox1.Controls.Add(this.ChkCoffee);
            this.groupBox1.Location = new System.Drawing.Point(35, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ChkBrownie
            // 
            this.ChkBrownie.AutoSize = true;
            this.ChkBrownie.Location = new System.Drawing.Point(30, 76);
            this.ChkBrownie.Name = "ChkBrownie";
            this.ChkBrownie.Size = new System.Drawing.Size(80, 21);
            this.ChkBrownie.TabIndex = 0;
            this.ChkBrownie.Text = "Brownie";
            this.ChkBrownie.UseVisualStyleBackColor = true;
            // 
            // ChkDount
            // 
            this.ChkDount.AutoSize = true;
            this.ChkDount.Location = new System.Drawing.Point(30, 49);
            this.ChkDount.Name = "ChkDount";
            this.ChkDount.Size = new System.Drawing.Size(68, 21);
            this.ChkDount.TabIndex = 0;
            this.ChkDount.Text = "Donut";
            this.ChkDount.UseVisualStyleBackColor = true;
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(30, 22);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(71, 21);
            this.ChkCoffee.TabIndex = 0;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.Location = new System.Drawing.Point(35, 293);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(104, 42);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(245, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(245, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // FrmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(465, 389);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCheckBox";
            this.Text = "CheckBox Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkBrownie;
        private System.Windows.Forms.CheckBox ChkDount;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}