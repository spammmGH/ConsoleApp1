using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class FindEvenorODIQ
    {
        public int result;
        public FindEvenorODIQ(string str)
        {
            string[] arrStr = str.Split(' ');
            int[] arrInt = new int[arrStr.Length];
            int i = 0;
            foreach (string s in arrStr)
            {
                arrInt[i] = Convert.ToInt32(s);
                    ++i;
            }
            i = 0;
            int even = 0;
            int odd = 0;
            int currentEven = 0;
            int currentODD = 0;

            foreach (int j in arrInt)
            {
                if (j % 2 == 0)
                {
                    ++even;
                    currentEven = i;
                }
                else
                {
                    odd++;
                    currentODD = i;
                }
                ++i;
            }
            if (odd < even)
            {
                result = currentODD +1;
            }
            else {
                result = currentEven + 1;
            }    
            
        }
    }
}
