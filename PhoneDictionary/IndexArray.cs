using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDictionary
{
    internal class IndexArray
    {
        protected PhoneRecord[] phoneRecords;
        protected int[] indexArray;

        public IndexArray(IEnumerable<PhoneRecord> collection)
        {
            phoneRecords = collection.ToArray();

            indexArray = new int[phoneRecords.Length];
            for (int i = 0; i < phoneRecords.Length; i++)
            {
                indexArray[i] = i;
            }
        }

        public virtual void Sort(IComparer<PhoneRecord> comp)
        {
            for(int i = 0; i < phoneRecords.Length - 1; i++)
            {
                int k = 0;
                for(int j = k + 1; j < phoneRecords.Length; j++, k++)
                {
                    if(comp.Compare(phoneRecords[indexArray[k]], phoneRecords[indexArray[j]]) > 0)
                    {
                        int tmp = indexArray[k];
                        indexArray[k] = indexArray[j];
                        indexArray[j] = tmp;
                    }
                }
            }
        }

        public int Length
        {
            get { return phoneRecords.Length; }
        }

        public PhoneRecord this[int index]
        {
            get
            {
                return phoneRecords[indexArray[index]];
            }

            set
            {
                phoneRecords[indexArray[index]] = value;
            }
        }
    }
}
