using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1._1
{
    public partial class FrmImage2 : Form
    {
        //Assembly _assambly;
        //Stream _imageStream;

        public FrmImage2()
        {
            InitializeComponent();
        }

        private void btnPicFile_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\Abdulaziz's\\IE-256\\Final_Project");
            }
            catch
            {
                MessageBox.Show("Image File not found");
            }

        }
        private void FrmImage2_Load(object sender, EventArgs e)
        {
            //_assambly = Assembly.GetExecutingAssembly();
            //_imageStream = _assambly.GetManifestResourceStream("MyGUI.res.KAU_Logo.jpg");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

