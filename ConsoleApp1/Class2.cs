using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a * b < 0 | a * c < 0 | b * c < 0 | a * b * c < 0)
            {
                return false;
            }
            else
            {
                if (a + b > c & a + c > b & b + c > a)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
