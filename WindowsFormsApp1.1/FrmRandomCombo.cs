using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGUI._1
{
    public partial class FrmRandomCombo : Form
    {
        Random r = new Random();

        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerateAAF_Click(object sender, EventArgs e)
        {
            cmbAAF.ResetText();
            cmbAAF.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1,51); i++ )
            {
                cmbAAF.Items.Add(r.Next(100, 999));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnResetAAF_Click(object sender, EventArgs e)
        {
            cmbAAF.ResetText();
            cmbAAF.Items.Clear();
            radioLessAAF.Checked = false;
            radioGraterAAF.Checked = false;
        }

        private void BtnGenerateEAF_Click(object sender, EventArgs e)
        {
            cmbEAF.ResetText();
            cmbEAF.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                cmbEAF.Items.Add(r.Next(100, 999));
            }
        }

        private void btnResetEAF_Click(object sender, EventArgs e)
        {
            cmbEAF.ResetText();
            cmbEAF.Items.Clear();
            radioLessEAF.Checked = false;
            radioGraterEAF.Checked = false;
        }
    }
}
