using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CamelStyle
    {

        public string Method(string str)
        {
            string US = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

           
            for (int i = 0; i < str.Length; i++)
            {
                foreach (char c in US)
                {
                    if (str[i].Equals(c) & i > 0)
                    {
                        str = str.Insert(i," ");
                        i++;
                        break;
                    }
                }
            }
            return str;
            
        }
    }
}
// решение от Codea wars 
//    new Regex("([A-Z])").Replace(str, " $1");
