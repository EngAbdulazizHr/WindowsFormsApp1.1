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
    public partial class FrmCheckBox : Form
    {
        public FrmCheckBox()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ChkCoffee.Checked == true)
            {
                msg = ChkCoffee.Text;
            }
            if (ChkDount.Checked == true)
            {
                msg = msg + ChkDount.Text;
            }
            if (ChkBrownie.Checked == true)
            {
                msg = msg + "" + ChkBrownie.Text;
            }
            MessageBox.Show(msg);
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + "Ordered.");
            }
                else
            {
                MessageBox.Show("Nothing Orderd.");
            }
        }

            private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }
    }
}
