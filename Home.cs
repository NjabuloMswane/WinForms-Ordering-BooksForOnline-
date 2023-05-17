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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookName = "The Secrets We Keep";
            int price = 190;
            int qty = int.Parse(nudQty1.Text);
            HomeC objHom = new HomeC(price, qty, bookName);                 //instanciating
            StreamWriter objSW = new StreamWriter(@"cart_information.txt", true); //opening a stream to write data to.
            using (objSW)
            {
                objSW.WriteLine(objHom.DisplayCartInformation());    //writing the HomeC return method to the textfile.
            }
            MessageBox.Show("Item added to Cart!");                 //show notification when process complete.
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
        
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyTheShinning_Click(object sender, EventArgs e)
        {
            string bookName = "The Shinning";
            int price = 300;
            int qty = int.Parse(nudqty.Value.ToString());
            HomeC objHom = new HomeC(price, qty, bookName);
            StreamWriter objSW = new StreamWriter(@"cart_information.txt", true);
            using(objSW)
            {
                objSW.WriteLine(objHom.DisplayCartInformation());
            }
            MessageBox.Show("Item added to Cart!");
        }

        private void btnBuyPromisedLand_Click(object sender, EventArgs e)
        {
            string bookName = "A Promised Land";
            int price = 400;
            int qty = int.Parse(nudQty3.Text);
            HomeC objHom = new HomeC(price, qty, bookName);
            StreamWriter objSW = new StreamWriter(@"cart_information.txt", true);
            using (objSW)
            {
                objSW.WriteLine(objHom.DisplayCartInformation());
            }
            MessageBox.Show("Items Added to Cart");
        
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnButIT_Click(object sender, EventArgs e)
        {
            string bookName = "IT";
            int price = 570;
            int qty = int.Parse(nudQty2.Text);
            HomeC objHom = new HomeC(price, qty, bookName);
            StreamWriter objSW = new StreamWriter(@"cart_information.txt", true);
            using (objSW)
            {
                objSW.WriteLine(objHom.DisplayCartInformation());
            }
            MessageBox.Show("Item added to Cart!");
        }

        private void btnBuyPrisonerAzkaban_Click(object sender, EventArgs e)
        {
            string bookName = "The Prisoner Of Azkaban";
            int price = 600;
            int qty = int.Parse(nudQty4.Text);
            HomeC objHom = new HomeC(price, qty, bookName);
            StreamWriter objSW = new StreamWriter(@"cart_information.txt", true);
            using (objSW)
            {
                objSW.WriteLine(objHom.DisplayCartInformation());
            }
            MessageBox.Show("Item added to Cart!");
        }

        private void btnBuyMadHouse_Click(object sender, EventArgs e)
        {
            string bookName = "Madhouse at the End of the Earth";
            int qty = int.Parse(nudQty5.Text);
            int price = 650;
            HomeC objHom = new HomeC(price, qty, bookName);
            StreamWriter objSW = new StreamWriter(@"cart_information.txt", true);
            using (objSW)
            {
                objSW.WriteLine(objHom.DisplayCartInformation());
            }
            MessageBox.Show("Item added to Cart!");
        }

        private void btnGoToCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCart f9 = new frmCart();
            f9.Show();
        }
    }
}
