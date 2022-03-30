using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDictionary
{
    internal class PhoneRecord : Person
    {
        string phone;

        public PhoneRecord(string name, string secondName, string phone) : base(name, secondName)
        {
            this.phone = phone;
        }

        public string Phone
        {
            set { phone = value; }
            get { return phone; }
        }
    }
}
