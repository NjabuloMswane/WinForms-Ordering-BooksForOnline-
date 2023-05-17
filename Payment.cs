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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            grpCardDetails.Enabled = false;
            grpContactInformation.Enabled = false;
            grpDeliveryInformation.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reading from the Cart Texfile
            string lineRec = "";
            string[] lineArray = new string[3];  //declares 3 arrays
            StreamWriter objSSW = new StreamWriter(@"delivery_information.txt", true);
            using (objSSW)
            {
                objSSW.WriteLine("ITEMS\n");
            }
            StreamReader objSRR = new StreamReader(@"cart_information.txt", true);
            using (objSRR)
            {
                lineRec = objSRR.ReadLine();       //reads the first line of the text line
                while (lineRec != null)
                {
                    lineArray = lineRec.Split(',');
                    string name = (lineArray[0]);    //parsing textfile values to variables
                    int qty = int.Parse(lineArray[1]);
                    int price = int.Parse(lineArray[2]);
                    lineRec = objSRR.ReadLine();
                    StreamWriter objSSSW = new StreamWriter(@"delivery_information.txt", true);
                    using (objSSSW)
                    {
                        objSSSW.WriteLine(name + "    x" + qty + "    " + price.ToString("C")); //manipulating textfile variables
                    }
                }
            }
            StreamWriter objSSSSW = new StreamWriter(@"delivery_information.txt", true);
            using (objSSSSW)
            {
                int totalPrice = 0;
                CartC objCar = new CartC(totalPrice);   //instanciating

                objSSSSW.WriteLine("\nTotal Cost: " + objCar.calcCheckoutPrice().ToString("C"));
            }


               string firstName, lastName, id, address, city, zipCode, province, cellNumber, email;
               firstName = txtFirstName.Text;
               lastName = txtLastName.Text;
               id = txtID.Text;
               address = txtAddress.Text;
               city = txtCity.Text;
               zipCode = txtZipCode.Text;
               province = txtProvince.Text;
               cellNumber = txtCellNumber.Text;
               email = txtEmail.Text;

               PaymentC objPay = new PaymentC(firstName, lastName, id, address, city, zipCode, province, cellNumber, email);
               StreamWriter objSW = new StreamWriter(@"delivery_information.txt", true);
               using (objSW)
               {
                   objSW.WriteLine(objPay.Display());
               }
                MessageBox.Show("Payment Successfull!");
                this.Hide();
                frmInvoice f12 = new frmInvoice();
                f12.Show();

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Enabled = false;
            grpContactInformation.Enabled = true;
            grpDeliveryInformation.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Enabled = true;
            grpContactInformation.Enabled = true;
            grpDeliveryInformation.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCart f16 = new frmCart();
            f16.Show();
        }
    }
}
