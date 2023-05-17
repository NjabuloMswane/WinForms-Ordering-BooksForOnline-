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
    public partial class frmForgot_Password : Form
    {
        public frmForgot_Password()
        {
            InitializeComponent();
        }

        private void btnSearchPassword_Click(object sender, EventArgs e)
        {
            string lineRec = "";                 //store record of each line on text file
            string[] lineArray = new string[2];  //declare and creating array
            string username;           //Declare Login page varianles
            username = txtUsername.Text;         //Parse inputed data to declared variables
            int numTest = 0;
            StreamReader file = new StreamReader(@"Credentials.txt");
            using (file)
            {
                lineRec = file.ReadLine();       //reads the first line of the text line
                while (lineRec != null)
                {
                    lineArray = lineRec.Split(',');
                    if (username == lineArray[0]) //comparing with username on the textfile
                    {

                        MessageBox.Show("Your password is " + lineArray[1]);
                        numTest++;
                        this.Hide();
                        frmLogin f3 = new frmLogin();
                        f3.Show();

                    }                 
                    lineRec = file.ReadLine();
                }
                if (numTest == 0)
                {
                    MessageBox.Show("No password corresponding to username " + username + " found!. Try Creating an account.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f16 = new frmLogin();
            f16.Show();
        }

        private void frmForgot_Password_Load(object sender, EventArgs e)
        {

        }
    }
}
