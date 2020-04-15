namespace MyGUI._1
{
    partial class FrmRandomCombo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGenerateAAF = new System.Windows.Forms.Button();
            this.btnResetAAF = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.BtnGenerateEAF = new System.Windows.Forms.Button();
            this.btnResetEAF = new System.Windows.Forms.Button();
            this.cmbAAF = new System.Windows.Forms.ComboBox();
            this.cmbEAF = new System.Windows.Forms.ComboBox();
            this.radioLessAAF = new System.Windows.Forms.RadioButton();
            this.radioGraterAAF = new System.Windows.Forms.RadioButton();
            this.radioLessEAF = new System.Windows.Forms.RadioButton();
            this.radioGraterEAF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz03_AAF19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quiz03_EAF19";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Count:";
            // 
            // BtnGenerateAAF
            // 
            this.BtnGenerateAAF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnGenerateAAF.Location = new System.Drawing.Point(179, 107);
            this.BtnGenerateAAF.Name = "BtnGenerateAAF";
            this.BtnGenerateAAF.Size = new System.Drawing.Size(86, 31);
            this.BtnGenerateAAF.TabIndex = 1;
            this.BtnGenerateAAF.Text = "Generate";
            this.BtnGenerateAAF.UseVisualStyleBackColor = false;
            this.BtnGenerateAAF.Click += new System.EventHandler(this.BtnGenerateAAF_Click);
            // 
            // btnResetAAF
            // 
            this.btnResetAAF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnResetAAF.Location = new System.Drawing.Point(179, 256);
            this.btnResetAAF.Name = "btnResetAAF";
            this.btnResetAAF.Size = new System.Drawing.Size(86, 31);
            this.btnResetAAF.TabIndex = 1;
            this.btnResetAAF.Text = "Reset";
            this.btnResetAAF.UseVisualStyleBackColor = false;
            this.btnResetAAF.Click += new System.EventHandler(this.btnResetAAF_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBack.Location = new System.Drawing.Point(381, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 44);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BtnGenerateEAF
            // 
            this.BtnGenerateEAF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnGenerateEAF.Location = new System.Drawing.Point(510, 107);
            this.BtnGenerateEAF.Name = "BtnGenerateEAF";
            this.BtnGenerateEAF.Size = new System.Drawing.Size(86, 31);
            this.BtnGenerateEAF.TabIndex = 1;
            this.BtnGenerateEAF.Text = "Generate";
            this.BtnGenerateEAF.UseVisualStyleBackColor = false;
            // 
            // btnResetEAF
            // 
            this.btnResetEAF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnResetEAF.Location = new System.Drawing.Point(510, 256);
            this.btnResetEAF.Name = "btnResetEAF";
            this.btnResetEAF.Size = new System.Drawing.Size(86, 31);
            this.btnResetEAF.TabIndex = 1;
            this.btnResetEAF.Text = "Reset";
            this.btnResetEAF.UseVisualStyleBackColor = false;
            // 
            // cmbAAF
            // 
            this.cmbAAF.FormattingEnabled = true;
            this.cmbAAF.Location = new System.Drawing.Point(27, 111);
            this.cmbAAF.Name = "cmbAAF";
            this.cmbAAF.Size = new System.Drawing.Size(121, 24);
            this.cmbAAF.TabIndex = 2;
            // 
            // cmbEAF
            // 
            this.cmbEAF.FormattingEnabled = true;
            this.cmbEAF.Location = new System.Drawing.Point(351, 111);
            this.cmbEAF.Name = "cmbEAF";
            this.cmbEAF.Size = new System.Drawing.Size(121, 24);
            this.cmbEAF.TabIndex = 2;
            // 
            // radioLessAAF
            // 
            this.radioLessAAF.AutoSize = true;
            this.radioLessAAF.Location = new System.Drawing.Point(179, 175);
            this.radioLessAAF.Name = "radioLessAAF";
            this.radioLessAAF.Size = new System.Drawing.Size(124, 21);
            this.radioLessAAF.TabIndex = 3;
            this.radioLessAAF.TabStop = true;
            this.radioLessAAF.Text = "Less Than 500";
            this.radioLessAAF.UseVisualStyleBackColor = true;
            // 
            // radioGraterAAF
            // 
            this.radioGraterAAF.AutoSize = true;
            this.radioGraterAAF.Location = new System.Drawing.Point(179, 219);
            this.radioGraterAAF.Name = "radioGraterAAF";
            this.radioGraterAAF.Size = new System.Drawing.Size(143, 21);
            this.radioGraterAAF.TabIndex = 3;
            this.radioGraterAAF.TabStop = true;
            this.radioGraterAAF.Text = "Greater Than 500";
            this.radioGraterAAF.UseVisualStyleBackColor = true;
            // 
            // radioLessEAF
            // 
            this.radioLessEAF.AutoSize = true;
            this.radioLessEAF.Location = new System.Drawing.Point(510, 175);
            this.radioLessEAF.Name = "radioLessEAF";
            this.radioLessEAF.Size = new System.Drawing.Size(124, 21);
            this.radioLessEAF.TabIndex = 3;
            this.radioLessEAF.TabStop = true;
            this.radioLessEAF.Text = "Less Than 500";
            this.radioLessEAF.UseVisualStyleBackColor = true;
            // 
            // radioGraterEAF
            // 
            this.radioGraterEAF.AutoSize = true;
            this.radioGraterEAF.Location = new System.Drawing.Point(510, 219);
            this.radioGraterEAF.Name = "radioGraterEAF";
            this.radioGraterEAF.Size = new System.Drawing.Size(143, 21);
            this.radioGraterEAF.TabIndex = 3;
            this.radioGraterEAF.TabStop = true;
            this.radioGraterEAF.Text = "Greater Than 500";
            this.radioGraterEAF.UseVisualStyleBackColor = true;
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(662, 431);
            this.Controls.Add(this.radioGraterEAF);
            this.Controls.Add(this.radioLessEAF);
            this.Controls.Add(this.radioGraterAAF);
            this.Controls.Add(this.radioLessAAF);
            this.Controls.Add(this.cmbEAF);
            this.Controls.Add(this.cmbAAF);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnResetEAF);
            this.Controls.Add(this.btnResetAAF);
            this.Controls.Add(this.BtnGenerateEAF);
            this.Controls.Add(this.BtnGenerateAAF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRandomCombo";
            this.Text = "RandomCombo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGenerateAAF;
        private System.Windows.Forms.Button btnResetAAF;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button BtnGenerateEAF;
        private System.Windows.Forms.Button btnResetEAF;
        private System.Windows.Forms.ComboBox cmbAAF;
        private System.Windows.Forms.ComboBox cmbEAF;
        private System.Windows.Forms.RadioButton radioLessAAF;
        private System.Windows.Forms.RadioButton radioGraterAAF;
        private System.Windows.Forms.RadioButton radioLessEAF;
        private System.Windows.Forms.RadioButton radioGraterEAF;
    }
}