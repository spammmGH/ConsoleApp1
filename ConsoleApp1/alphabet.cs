using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class alphabet
    {
        public string M1 (string input)
        {
            string[] alphabet = new string[] {"a","b","c","d" };
            for (int i=0; i<alphabet.Length; i++)
            {
                int b = i;
                input = input.Replace(alphabet[i], b.ToString());
            }
            return input;
        }
    }
}
