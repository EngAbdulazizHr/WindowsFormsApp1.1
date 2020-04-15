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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();

            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
            CmbDays.Items.Add("Funday");
            CmbDays.Items.Add("Examday");
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {
           

           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShowSelected1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnShowSelected2_Click(object sender, EventArgs e)
        {
            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void BtnShowSelected3_Click(object sender, EventArgs e)
        {
            var item = CmbDays.SelectedItem;
            MessageBox.Show(item.ToString());
        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
                MessageBox.Show("Can't remove the last item");
        }

        private void BtnRemove2ndLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
                MessageBox.Show("Cant't remove 2nd last item");
        }
    }
}
