namespace MyGUI._1
{
    partial class FrmCombo
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
            this.BtnShowSelected1 = new System.Windows.Forms.Button();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.BtnShowSelected2 = new System.Windows.Forms.Button();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveLast = new System.Windows.Forms.Button();
            this.BtnRemove2ndLast = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnShowSelected3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowSelected1
            // 
            this.BtnShowSelected1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnShowSelected1.Location = new System.Drawing.Point(41, 27);
            this.BtnShowSelected1.Name = "BtnShowSelected1";
            this.BtnShowSelected1.Size = new System.Drawing.Size(84, 71);
            this.BtnShowSelected1.TabIndex = 0;
            this.BtnShowSelected1.Text = "Show Selected Method 1";
            this.BtnShowSelected1.UseVisualStyleBackColor = false;
            this.BtnShowSelected1.Click += new System.EventHandler(this.BtnShowSelected1_Click);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(41, 192);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(119, 49);
            this.BtnRemoveByIndex.TabIndex = 0;
            this.BtnRemoveByIndex.Text = "Remove by Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = false;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // BtnShowSelected2
            // 
            this.BtnShowSelected2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnShowSelected2.Location = new System.Drawing.Point(180, 27);
            this.BtnShowSelected2.Name = "BtnShowSelected2";
            this.BtnShowSelected2.Size = new System.Drawing.Size(84, 71);
            this.BtnShowSelected2.TabIndex = 0;
            this.BtnShowSelected2.Text = "Show Selected Method 2";
            this.BtnShowSelected2.UseVisualStyleBackColor = false;
            this.BtnShowSelected2.Click += new System.EventHandler(this.BtnShowSelected2_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnRemoveByName.Location = new System.Drawing.Point(205, 192);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(119, 49);
            this.BtnRemoveByName.TabIndex = 0;
            this.BtnRemoveByName.Text = "Removed by Name";
            this.BtnRemoveByName.UseVisualStyleBackColor = false;
            this.BtnRemoveByName.Click += new System.EventHandler(this.BtnRemoveByName_Click);
            // 
            // BtnRemoveLast
            // 
            this.BtnRemoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnRemoveLast.Location = new System.Drawing.Point(460, 30);
            this.BtnRemoveLast.Name = "BtnRemoveLast";
            this.BtnRemoveLast.Size = new System.Drawing.Size(133, 68);
            this.BtnRemoveLast.TabIndex = 1;
            this.BtnRemoveLast.Text = "Remove last item ";
            this.BtnRemoveLast.UseVisualStyleBackColor = false;
            this.BtnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(460, 147);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(133, 68);
            this.BtnRemove2ndLast.TabIndex = 1;
            this.BtnRemove2ndLast.Text = "Remove 2nd last item";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = false;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.BtnRemove2ndLast_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.Location = new System.Drawing.Point(460, 289);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(107, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(41, 115);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(223, 24);
            this.CmbDays.TabIndex = 0;
            // 
            // BtnShowSelected3
            // 
            this.BtnShowSelected3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnShowSelected3.Location = new System.Drawing.Point(315, 27);
            this.BtnShowSelected3.Name = "BtnShowSelected3";
            this.BtnShowSelected3.Size = new System.Drawing.Size(84, 71);
            this.BtnShowSelected3.TabIndex = 3;
            this.BtnShowSelected3.Text = "Show Selected Method 3";
            this.BtnShowSelected3.UseVisualStyleBackColor = false;
            this.BtnShowSelected3.Click += new System.EventHandler(this.BtnShowSelected3_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(654, 356);
            this.Controls.Add(this.BtnShowSelected3);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnRemove2ndLast);
            this.Controls.Add(this.BtnRemoveLast);
            this.Controls.Add(this.BtnRemoveByName);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShowSelected2);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.BtnShowSelected1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelected1;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button BtnShowSelected2;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveLast;
        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnShowSelected3;
    }
}