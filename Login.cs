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

namespace Digital_Book_Ordering_System_GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin() => InitializeComponent();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string lineRec = "";                 //store record of each line on text file
            string[] lineArray = new string[2];  //declare and creating array
            string username, password;           //Declare Login page varianles
            int numTest = 0;                     //counter to control messageBox execution
            username = txtUsername.Text;         //Parse inputed data to declared variables
            password = txtPassword.Text;

            StreamReader file = new StreamReader(@"Credentials.txt");
            using(file)
            {
                lineRec = file.ReadLine();       //reads the first line of the text line
                while (lineRec != null)
                {
                    lineArray = lineRec.Split(',');
                    if((username == (lineArray[0]))&&(password == (lineArray[1]))) //comparing with username on the textfile
                    {
                        
                        MessageBox.Show("Correct Credentials, Access Granted!");
                        numTest++;
                        this.Hide();
                        frmHome f3 = new frmHome();
                        f3.Show();

                    }
                    
                    lineRec = file.ReadLine();
                }
                if (numTest == 0)
                {
                    MessageBox.Show("Incorrect Credentials, Access Denied!");
                }
                
            }

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister f2 = new frmRegister();
            f2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked == true)
            {
                txtUsername.UseSystemPasswordChar = false;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtUsername.UseSystemPasswordChar = true;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgot_Password f15 = new frmForgot_Password();
            f15.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
