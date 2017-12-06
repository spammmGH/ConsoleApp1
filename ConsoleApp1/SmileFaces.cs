using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class SmileFaces
    {
        //: or ;
        //nose  - or ~
        // rote must  ) or D.

        public int count;
        public SmileFaces(string[] str)
        {
            count = 0;
            string regPattern = @"^((\:)|(\;)){1}\-{0,1}[),D]$";
            Regex regex = new Regex(regPattern);
            foreach (string t in str)
            {
                Console.WriteLine(t);
                if (regex.IsMatch(t)) 
                {
                    Console.WriteLine("true");
                    ++count;
                }

            }
        }
    }
}
