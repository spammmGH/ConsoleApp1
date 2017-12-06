using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PhoneNumber
    {
        public string PN;
        public PhoneNumber(int[] input)
        {
            PN = "";
            foreach (int i in input)
            {
                PN += i;
            }
            PN = PN.Insert(0, "(").Insert(4, ") ").Insert(9, "-");
        }
    }

    //public static string CreatePhoneNumber(int[] numbers) => // решение с codeWars
    //new Regex("(...)(...)(....)").Replace(String.Concat(numbers), "($1) $2-$3"); //решение с CodeWars
}
