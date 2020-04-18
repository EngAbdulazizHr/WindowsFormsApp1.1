using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace MyGUI
{
    public partial class FrmImage : Form
    {
        Assembly _assambly;
        Stream _imageStream;
        public FrmImage()
        {
            InitializeComponent();
        }

        private void btnPicFile_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\IE-322\\C_Sharp_logo.png");
            }
            catch 
            {
                MessageBox.Show("Image File not found");
            }
            
        }

        private void FrmImage_Load(object sender, EventArgs e)
        {
            _assambly = Assembly.GetExecutingAssembly();
            _imageStream = _assambly.GetManifestResourceStream("MyGUI.res.EngineeringNewPic.jpg");

        }

        private void btnPicRes_Click(object sender, EventArgs e)
        {
            try
            {
                picTry2.Image = Image.FromStream(_imageStream);
            }
            catch 
            {

                MessageBox.Show("Error creating image from resource!");
            }
        }
    }
}
