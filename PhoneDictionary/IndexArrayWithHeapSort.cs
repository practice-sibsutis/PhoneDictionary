using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDictionary
{
    internal class IndexArrayWithHeapSort : IndexArray
    {
        public IndexArrayWithHeapSort(IEnumerable<PhoneRecord> collection) : base(collection)
        {
        }

        //Реализовать пирамидальную сортировку
        public override void Sort(IComparer<PhoneRecord> comp)
        {
        }
    }
}
