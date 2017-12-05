using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class money
    {
        // Допустим в исходной строке нужно заменить "руб." на "$",
        // а стоимость переместить после знака $
        public void m1()
        {
            string input = "Добро пожаловать в наш магазин, вот наши цены: \n" +
            "\t 1 кг. яблок - 20 руб. \n" +
            "\t 2 кг. апельсинов - 30 руб. \n";

            Console.WriteLine("Исходная строка:\n {0}", input);

            // В шаблоне используются 2 группы
            string pattern = @"\b(\d+)\W?(руб.)";

            // Строка замены "руб." на "$"
            string replacement1 = "$$$1";    // Перед первой группой ставится знак $,
                                             // вторая группа удаляется без замены

            input = Regex.Replace(input, pattern, replacement1);
            Console.WriteLine("\nВидоизмененная строка: \n" + input);
        }
        
    }
}
