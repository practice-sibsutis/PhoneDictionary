using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDictionary
{
    internal class Person
    {
        private string name;
        private string secondName;

        public Person(string name, string secondName)
        {
            this.name = name;
            this.secondName = secondName;
        }

        public override string ToString()
        {
            return name + " " + secondName;
        }

        public string Name
        {
            set => name = value;
            get => name;
        }

        public string SecondName
        {
            get => secondName;
        }
    }
}
