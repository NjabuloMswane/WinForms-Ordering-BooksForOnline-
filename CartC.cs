using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Digital_Book_Ordering_System_GUI
{
    public class CartC
    {
        private int totalPrice;

        public int propTotalPrice { get => totalPrice; set => totalPrice = value; }

        public CartC()
        {
            propTotalPrice = 0;
        }

        public CartC(int tp)
        {
            propTotalPrice = tp;
        }

        public int calcCheckoutPrice()
        {
            string lineRec = "";
            string[] lineArray = new string[3];
            StreamReader objSR = new StreamReader(@"cart_information.txt", true);
            using (objSR)
            {
                lineRec = objSR.ReadLine();       //reads the first line of the text line
                while (lineRec != null)
                {
                    lineArray = lineRec.Split(',');
                    totalPrice += int.Parse(lineArray[2]);

                    lineRec = objSR.ReadLine();

                }


            }
            return totalPrice;
        }
    }
}
