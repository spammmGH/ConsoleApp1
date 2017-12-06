using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//проверка правильности решения судоку. Т.е. на вход заполненная таблица 9 на 9 и проверить правильно 
//заполнения
namespace ConsoleApp1
{
    class SudokuCheck
    {
        public string Valid(int [][] input)
        {
            List<int> list = new List<int>();

            for (int i = 0; i<9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    list.Add(input[i][j]);
                }
            }
            if (list.Contains(0))
            {
                return "Try again!";
            }
            //int[][] aaaaa = new int[3][];
            //aaaaa[0] = new int[3] { 5, 4, 3 };
            //int ab = aaaaa[0][1];
            //Console.WriteLine(ab);

            for (int i = 0; i<9; i++)
            {
                for (int j = 0; j<9; j++)
                {
                    list.Add(input[i][j]);
                }
                if (!contain(list))
                {
                    Console.WriteLine("block 1");
                    return "Try again!";
                }
                list.Clear();

                for (int j =0; j<9; j++)
                {
                    list.Add(input[j][i]);
                }
                if (!contain(list))
                {
                    Console.WriteLine("block 2");
                    return "Try again!";
                }
                list.Clear();
            }

            //проверка квадратов 3 на 3
            for (int i = 0; i<3; i++)
            {
                for (int k = 0; k<2; k++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        list.Add(input[3 * i][j + k * 3]);
                        list.Add(input[3 * i + 1][j + k * 3]);
                        list.Add(input[3 * i + 2][j + k * 3]);
                    }
                    if (!contain(list))
                    {
                        Console.WriteLine("block 3");
                        return "Try again!";
                        
                    }
                    list.Clear();
                }
                
            }
            return "Finished!";

        }

        bool contain(List<int> list)
        {
            int[] chck = { 1,2,3,4,5,6,7,8,9 };
            bool b = true;
            foreach (int i in chck)
            {
                b = list.Contains(i);
                if (!b)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
