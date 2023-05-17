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
    public partial class frmRegister : Form
    {
        public frmRegister() => InitializeComponent();

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtCreateUsername.Text;
            string password = txtCreatePassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            
            LoginC objL = new LoginC(username, password);
            StreamWriter objSW = new StreamWriter(@"credentials.txt", true);
            using(objSW)
            {
                if (txtCreatePassword.Text == txtConfirmPassword.Text)
                {
                   lblCheck3.ForeColor = Color.Green;
                   lblCheck3.BackColor = Color.Transparent;
                   lblCheck3.Text = "Password matching!";

                   objSW.WriteLine(objL.Validate());
                   MessageBox.Show("Account Successfully Created!");

                   this.Hide();
                   frmLogin f3 = new frmLogin();
                   f3.Show();
                
                }
                else
                {
                  lblCheck3.ForeColor = Color.Red;
                  lblCheck3.BackColor = Color.Transparent;
                  lblCheck3.Text = "Password is not matching!";
                }
                
            }
            
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtCreatePassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtCreatePassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
