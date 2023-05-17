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
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            string lineRec = "";
            string[] lineArray = new string[3];  //declares 3 arrays
            int id = 0;
            StreamReader objSR = new StreamReader(@"cart_information.txt", true);
            using (objSR)
            {
                lineRec = objSR.ReadLine();       //reads the first line of the text line
                while (lineRec != null)
                {
                    lineArray = lineRec.Split(',');
                    string name = (lineArray[0]);     //parsing the values from textfile
                    int qty = int.Parse(lineArray[1]);
                    string totalPriceGrid = (lineArray[2]);

                    lineRec = objSR.ReadLine();
                    dataGridView1.Rows.Add(id, name, qty, totalPriceGrid);
                    id += 1; ;
                }
                MessageBox.Show("Items Shown!");

            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;
            CartC objCar = new CartC(totalPrice);   //instanciating
            lblCheckout.Text = ("\nTotal Cost: " + "\n" + objCar.calcCheckoutPrice().ToString("C"));
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayment f11 = new frmPayment();
            f11.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome f13 = new frmHome();
            f13.Show();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {

        }
    }
}
