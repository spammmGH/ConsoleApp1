using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WestWest
    {
        public string[] WYN;
        public WestWest(string[] str)
        {
            string oPcurrent="";

            List<string> strList = new List<string>(str);
            //strList.AddRange(str);
            //"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"

            for (int i = 0; i < strList.Count; i++)
            {
                //Console.WriteLine(strList[i]);
                switch (strList[i])
                {
                    case "WEST":
                        oPcurrent = "EAST";
                        break;
                    case "EAST":
                        oPcurrent = "WEST";
                        break;
                    case "NORTH":
                        oPcurrent = "SOUTH";
                        break;
                    case "SOUTH":
                        oPcurrent = "NORTH";
                        break;
                }
                if(i<(strList.Count-1))
                {
                    if (oPcurrent.Equals(strList[i + 1]))
                    {
                        Console.WriteLine("\n"+strList[i] + "removeThis");
                        strList.RemoveAt(i);
                        Console.WriteLine(strList.Count);
                        Console.WriteLine(strList[i] + " removeThis");
                        strList.RemoveAt(i);
                        Console.WriteLine(strList.Count);

                       
                        if (i > 0)
                        {
                            --i;
                        }
                        --i;
                    }
                }
                   /* if (i+1 == strList.Count)
                {
                    break;
                }*/
                }

            WYN = new string[strList.Count];
            for (int i = 0; i<strList.Count; i++)
            {
                WYN[i] = strList[i];
            }

        }
    }
}
