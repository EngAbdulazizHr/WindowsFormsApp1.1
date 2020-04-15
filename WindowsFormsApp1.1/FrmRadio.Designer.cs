namespace MyGUI._1
{
    partial class FrmRadio
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.RdoRed = new System.Windows.Forms.RadioButton();
            this.RdoGreen = new System.Windows.Forms.RadioButton();
            this.RdoBlue = new System.Windows.Forms.RadioButton();
            this.RdoYellow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoRed1 = new System.Windows.Forms.RadioButton();
            this.RdoYellow1 = new System.Windows.Forms.RadioButton();
            this.RdoGreen1 = new System.Windows.Forms.RadioButton();
            this.RdoBlue1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnReset.Location = new System.Drawing.Point(56, 39);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(140, 36);
            this.BtnReset.TabIndex = 0;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.Location = new System.Drawing.Point(56, 332);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(140, 36);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // RdoRed
            // 
            this.RdoRed.AutoSize = true;
            this.RdoRed.Location = new System.Drawing.Point(56, 167);
            this.RdoRed.Name = "RdoRed";
            this.RdoRed.Size = new System.Drawing.Size(55, 21);
            this.RdoRed.TabIndex = 1;
            this.RdoRed.TabStop = true;
            this.RdoRed.Text = "Red";
            this.RdoRed.UseVisualStyleBackColor = true;
            this.RdoRed.CheckedChanged += new System.EventHandler(this.RdoRed_CheckedChanged);
            // 
            // RdoGreen
            // 
            this.RdoGreen.AutoSize = true;
            this.RdoGreen.Location = new System.Drawing.Point(56, 194);
            this.RdoGreen.Name = "RdoGreen";
            this.RdoGreen.Size = new System.Drawing.Size(69, 21);
            this.RdoGreen.TabIndex = 1;
            this.RdoGreen.TabStop = true;
            this.RdoGreen.Text = "Green";
            this.RdoGreen.UseVisualStyleBackColor = true;
            this.RdoGreen.CheckedChanged += new System.EventHandler(this.RdoGreen_CheckedChanged);
            // 
            // RdoBlue
            // 
            this.RdoBlue.AutoSize = true;
            this.RdoBlue.Location = new System.Drawing.Point(56, 221);
            this.RdoBlue.Name = "RdoBlue";
            this.RdoBlue.Size = new System.Drawing.Size(57, 21);
            this.RdoBlue.TabIndex = 1;
            this.RdoBlue.TabStop = true;
            this.RdoBlue.Text = "Blue";
            this.RdoBlue.UseVisualStyleBackColor = true;
            this.RdoBlue.CheckedChanged += new System.EventHandler(this.RdoBlue_CheckedChanged);
            // 
            // RdoYellow
            // 
            this.RdoYellow.AutoSize = true;
            this.RdoYellow.Location = new System.Drawing.Point(56, 248);
            this.RdoYellow.Name = "RdoYellow";
            this.RdoYellow.Size = new System.Drawing.Size(69, 21);
            this.RdoYellow.TabIndex = 1;
            this.RdoYellow.TabStop = true;
            this.RdoYellow.Text = "Yellow";
            this.RdoYellow.UseVisualStyleBackColor = true;
            this.RdoYellow.CheckedChanged += new System.EventHandler(this.RdoYellow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoRed1);
            this.groupBox1.Controls.Add(this.RdoYellow1);
            this.groupBox1.Controls.Add(this.RdoGreen1);
            this.groupBox1.Controls.Add(this.RdoBlue1);
            this.groupBox1.Location = new System.Drawing.Point(214, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radios Buttons";
            // 
            // RdoRed1
            // 
            this.RdoRed1.AutoSize = true;
            this.RdoRed1.Location = new System.Drawing.Point(52, 27);
            this.RdoRed1.Name = "RdoRed1";
            this.RdoRed1.Size = new System.Drawing.Size(55, 21);
            this.RdoRed1.TabIndex = 1;
            this.RdoRed1.TabStop = true;
            this.RdoRed1.Text = "Red";
            this.RdoRed1.UseVisualStyleBackColor = true;
            // 
            // RdoYellow1
            // 
            this.RdoYellow1.AutoSize = true;
            this.RdoYellow1.Location = new System.Drawing.Point(52, 108);
            this.RdoYellow1.Name = "RdoYellow1";
            this.RdoYellow1.Size = new System.Drawing.Size(69, 21);
            this.RdoYellow1.TabIndex = 1;
            this.RdoYellow1.TabStop = true;
            this.RdoYellow1.Text = "Yellow";
            this.RdoYellow1.UseVisualStyleBackColor = true;
            // 
            // RdoGreen1
            // 
            this.RdoGreen1.AutoSize = true;
            this.RdoGreen1.Location = new System.Drawing.Point(52, 54);
            this.RdoGreen1.Name = "RdoGreen1";
            this.RdoGreen1.Size = new System.Drawing.Size(69, 21);
            this.RdoGreen1.TabIndex = 1;
            this.RdoGreen1.TabStop = true;
            this.RdoGreen1.Text = "Green";
            this.RdoGreen1.UseVisualStyleBackColor = true;
            // 
            // RdoBlue1
            // 
            this.RdoBlue1.AutoSize = true;
            this.RdoBlue1.Location = new System.Drawing.Point(52, 81);
            this.RdoBlue1.Name = "RdoBlue1";
            this.RdoBlue1.Size = new System.Drawing.Size(57, 21);
            this.RdoBlue1.TabIndex = 1;
            this.RdoBlue1.TabStop = true;
            this.RdoBlue1.Text = "Blue";
            this.RdoBlue1.UseVisualStyleBackColor = true;
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(496, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RdoYellow);
            this.Controls.Add(this.RdoBlue);
            this.Controls.Add(this.RdoGreen);
            this.Controls.Add(this.RdoRed);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnReset);
            this.Name = "FrmRadio";
            this.Text = "Radio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.RadioButton RdoRed;
        private System.Windows.Forms.RadioButton RdoGreen;
        private System.Windows.Forms.RadioButton RdoBlue;
        private System.Windows.Forms.RadioButton RdoYellow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoRed1;
        private System.Windows.Forms.RadioButton RdoYellow1;
        private System.Windows.Forms.RadioButton RdoGreen1;
        private System.Windows.Forms.RadioButton RdoBlue1;
    }
}