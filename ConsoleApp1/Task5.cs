using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task5
    {
        public string M1 (string input)
        {
            StringBuilder strBuilder = new StringBuilder();
            String pattern = @"\s*\n*\r*";
            Regex reg = new Regex(pattern);
            input = reg.Replace(input, "");

            int length = input.Length;

            for (int i = 0; i<length; i++)
            {
                for (int j = 0; j<length; j++)
                {
                    strBuilder = strBuilder.Append(input[j], i + 1);

                }
                strBuilder = strBuilder.Append('-');

            }
            string output = strBuilder.ToString();
            output = Regex.Replace(output, @"-\Z" ,"");
           
            return output;
        }
    }
}
