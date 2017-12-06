using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Interview
    {
        public bool Method(string str, string part1, string part2)
        {
            int j = 0;
            int k = 0;
            for (int i =0; i<str.Length; i++)
            {
                Console.WriteLine(str[i] + ":is ishem eto:");
                if (j < part1.Length)
                {
                    if (str[i].Equals(part1[j]))
                    {

                        Console.WriteLine("block 1 : " + part1[j]);
                        j++;
                        continue;
                    }
                }
                

                if (k < part1.Length)
                {
                    if (str[i].Equals(part2[k]))
                    {
                        Console.WriteLine("block 2 : " + part2[k]);
                        k++;
                        continue;
                    }
                }
                
            }
            Console.WriteLine(k + "- k block 1, - " + j + " block 2, " + str.Length + " length");
            if (k + j == str.Length)
            {
                return true;
            }
            return false;
        }
        
    }
}
