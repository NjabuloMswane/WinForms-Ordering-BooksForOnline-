using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Digital_Book_Ordering_System_GUI
{
    public class PaymentC
    {
        private string firstName, lastName, id, address, city, zipCode, province, cellNumber, email;

        public string propFirstName { get => firstName; set => firstName = value; }
        public string propLastName { get => lastName; set => lastName = value; }
        public string propId { get => id; set => id = value; }
        public string propAddress { get => address; set => address = value; }
        public string propCity { get => city; set => city = value; }
        public string propZipCode { get => zipCode; set => zipCode = value; }
        public string propProvince { get => province; set => province = value; }
        public string propCellNumber { get => cellNumber; set => cellNumber = value; }
        public string propEmail { get => email; set => email = value; }

        public PaymentC()
        {
            propFirstName = "";
            propLastName = "";
            propId = "";
            propAddress = "";
            propCity = "";
            propZipCode = "";
            propProvince = "";
            propCellNumber = "";
            propEmail = "";
        }

        public PaymentC(string fn, string ln, string id, string a, string c, string z, string p, string cn, string e)
        {
            propFirstName = fn;
            propLastName = ln;
            propId = id;
            propAddress = a;
            propCity = c;
            propZipCode = z;
            propProvince = p;
            propCellNumber = cn;
            propEmail = e;
        }

        public string Display()
        {
            string msg = "";
            msg += "\nCONTACT INFORMATION\n";
            msg += "\nName: " + firstName;
            msg += "\nSurname: " + lastName;
            msg += "\nID Number: " + id;
            msg += "\nEmail: " + email;
            msg += "\nPhone Number: " + cellNumber + "\n\n";
            msg += "DELIVERY INFORMATION\n";
            msg += "\nStreet Address: " + address;
            msg += "\nCity: " + city;
            msg += "\nZipCode: " + zipCode;
            msg += "\nProvince: " + province + "\n\n";
            msg += "  THANK YOU FOR SHOPPING AT BOOKMARK               ";
            msg += "\n                             ENJOY YOUR DAY!  ";
            msg += "\n***************************************************************";
            return msg;
        }
    }
}
