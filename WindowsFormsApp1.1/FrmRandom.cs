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
    public partial class FrmRandom : Form
    {
        Random y = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);
            lblRGB.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            BtnGenerate.BackColor = Color.FromArgb(r, g, b);
        }

        private void BtnRandomNo_Click(object sender, EventArgs e)
        {
            BtnRandomNo.Text = Convert.ToString(y.Next(1, 100));
        }
    }
}
