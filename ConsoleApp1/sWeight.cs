using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sWeight
    {
        public string weight;
        public int mWeight;

        public  sWeight(string s)
        {

            weight = s;
            int temp = 0;

            for (int j = 0; j < s.Length; j++) //считаю новый ВЕС
            {
                temp += s[j] - '0';
            }

            mWeight = temp;
        }
    }
}
