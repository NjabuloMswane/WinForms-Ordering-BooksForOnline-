using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Book_Ordering_System_GUI
{
    public class LoginC
    {
        //private attributes
        public string username;
        public string password;

        //property structures
        public string propUsername
        {
            get { return username; }
            set { username = value; }
        }

        public string propPassword
        {
            get { return password; }
            set { password = value; }
        }
        //default constructor
        public LoginC()
        {
            propUsername = "";
            propPassword = "";
        }

        //parameterised/overloaded constructor
        public LoginC(string U,string P)
        {
            propUsername = U;
            propPassword = P;
        }
        //method
        public string Validate()
        {
            return username + "," + password;
        }

    }
}
