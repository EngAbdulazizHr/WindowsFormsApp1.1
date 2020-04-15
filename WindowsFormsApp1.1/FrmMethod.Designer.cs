namespace IE322_App_KAU
{
    partial class frmMethods
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
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnDeposit.Location = new System.Drawing.Point(123, 21);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(98, 37);
            this.BtnDeposit.TabIndex = 0;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = false;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnCalc);
            this.groupBox1.Location = new System.Drawing.Point(39, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculater using Method";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "b";
            // 
            // BtnCalc
            // 
            this.BtnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnCalc.Location = new System.Drawing.Point(48, 169);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(98, 37);
            this.BtnCalc.TabIndex = 4;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = false;
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnWithdraw.Location = new System.Drawing.Point(123, 94);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(98, 37);
            this.BtnWithdraw.TabIndex = 2;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = false;
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnCheck.Location = new System.Drawing.Point(123, 159);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(98, 37);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = false;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.Location = new System.Drawing.Point(261, 269);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(98, 37);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDeposit);
            this.groupBox2.Controls.Add(this.BtnWithdraw);
            this.groupBox2.Controls.Add(this.BtnCheck);
            this.groupBox2.Location = new System.Drawing.Point(294, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 217);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IE Bank";
            // 
            // frmMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(590, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMethods";
            this.Text = "Methods";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}