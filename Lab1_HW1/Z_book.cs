using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1_HW
{
    internal class Z_book
    {
        private string name;
        private string phone;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Z_book(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
