using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDictionary
{
    internal class PhoneRecordComparerBySecondName : IComparer<PhoneRecord>
    {
        public int Compare(PhoneRecord? p1, PhoneRecord? p2)
        {
            if (p1 == null && p2 == null)
            {
                return 0;
            }

            return p1.SecondName.CompareTo(p2.SecondName);
        }
    }
}
