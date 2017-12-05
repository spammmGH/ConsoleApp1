using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    class Class1
    {
        string input = "231123    123312    1323 323/"; // то в чем будем менять
        string pattern1 = @"\s{2,}";
        string pattern = @"[a,i,o,u,y]";

        string target = "";
        public void m1()
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            input = Console.ReadLine();
            string output = regex.Replace(input, target);
            Console.WriteLine("Исходные данные: \n"+ input + "\n");
            Console.WriteLine("результат выполнения рег.выражения\n");
            Console.Beep();

            Console.WriteLine(output);

        }
        
    }
}
