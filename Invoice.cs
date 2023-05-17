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
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            //Reading from the Delivery textfile
            StreamReader objSR = new StreamReader(@"delivery_information.txt", true); //read all records from textfiles
            lstOutputInvoice.Items.Clear();

            using (objSR)
            {
                string record = objSR.ReadLine();
                while (record != null)
                {
                    lstOutputInvoice.Items.Add(record);    //displays all the texfile contents.
                    record = objSR.ReadLine();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice loaded to printer!");
        }

        private void lstOutputInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
