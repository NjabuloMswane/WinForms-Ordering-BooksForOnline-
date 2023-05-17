using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Book_Ordering_System_GUI
{
    public class HomeC
    {
        private int price;
        private int qty;
        private string bookName;

        public int propPrice
        {
            get { return price; }
            set { price = value; }
        }

        public int propQty
        {
            get { return qty; }
            set { qty = value; }
        }

        public string propBookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public HomeC()
        {
            propPrice = 0;
            propQty = 0;
            propBookName = "";
        }

        public HomeC(int P, int Q, string B)
        {
            propPrice = P;
            propQty = Q;
            propBookName = B;
        }

        public double calculateTotalPrice()
        {
            return price * qty;
        }

        public string DisplayCartInformation()
        {
            return bookName + "," + qty + "," + calculateTotalPrice();
        }
    }
}
