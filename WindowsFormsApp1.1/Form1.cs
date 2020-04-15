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
    public partial class FrmMain : Form
    {
        string username = "Abdulaziz";
        string myPassword = "1234";

        int attempt = 1;
        int MaxAttempts = 3;
        int x = 1;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
             while (attempt <= MaxAttempts)
            {
                if (TxtUser.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    return;
                }
                else
                {   // username is correct
                    // so check password			
                    if (TxtPw.Text != myPassword)
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login successful");



                        BtnLogin.Text = "Logout";
                        //toolStripStatusLabel1.Text = "You are logged in.";
                        // this.Width = 1600;
                        break; // come out of while loop
                    }//endif

                }//endif
            }//end while 
            
             /* if (x>=3)
            {
                MessageBox.Show("Program Terminated");
                Application.Exit();
            }
            if (TxtUser.Text=="Abdulaziz")
                {
                MessageBox.Show("Welcome");
            }
            else
            {
                x++;
                MessageBox.Show("Invalid UserName - Try Again");
                TxtUser.Text = "";
                
            }
            */
        }

        private void BtnRad_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void BtnChk_Click(object sender, EventArgs e)
        {
            FrmCheckBox frm = new FrmCheckBox();
            frm.ShowDialog();
        }

        private void BtnCom_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnRan_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnRC_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPb_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage();
            frm.ShowDialog();
        }

        private void BtnPb2_Click(object sender, EventArgs e)
        {
            //FrmImage2 frm = new FrmImage2();
            //frm.ShowDialog();
        }

        private void BtnMethods_Click(object sender, EventArgs e)
        {
            //FrmMethod frm = new FrmMethod();
            //frm.ShowDialog();
        }

        private void BtnClasses_Click(object sender, EventArgs e)
        {
           // FrmClasses frm = new FrmClasses
           //  frm.ShowDialog
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!  Welcome to My First Application in V.S By using C# - This app made by Abdulaziz Alharbi - 1845329 - IE322.S20");
        }


        //private void groupBox4_Enter(object sender, EventArgs e)




        //private void groupBox5_Enter(object sender, EventArgs e)




        //private void groupBox6_Enter(object sender, EventArgs e)




    }
}
