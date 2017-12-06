using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SmallestNumber
    {
        public long[] Method(long u)
        {
            long result = u;
            int a = 0;
            int b = 0;
            string workString = u.ToString();

            for (int i = 0; i < workString.Length; i++)
            {
                workString = u.ToString();
                char c = workString[i];
                workString = workString.Remove(i, 1);


                for (int j = 0; j <= workString.Length; j++)
                {
                    workString = workString.Insert(j, Convert.ToString(c));

                    if (Convert.ToInt64(workString) < result)
                    {
                        result = Convert.ToInt64(workString);
                        a = i;
                        b = j;
                    }
                    workString = workString.Remove(j, 1);
                }
            }
            Console.WriteLine(a + " i1 " + b + " i2");
            Console.WriteLine(result);
            long[] d = {result, a, b };
            return d;
        }     
    }
}
