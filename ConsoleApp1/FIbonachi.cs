using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FIbonachi
    {
        public ulong[] output;

        public FIbonachi(ulong input) {
            List < ulong > myList = new List<ulong> { 0, 1 };
            ulong current = 0;
            int i = 2;
            ulong[] temp = new ulong[3];

            while( current<input)
            {
                myList.Add(myList[i - 1] + myList[i - 2]);
                current = myList[i]*myList[i-1];
                i++;
            }
            if (current == input)
            {
                temp[2] = 1;
            }
            else
            {
                temp[2] = 0;
            }
            temp[0] = myList[i - 2];
            temp[1] = myList[i - 1];
            output = temp;

        }
    }
}
