using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class GoodOrEvil
    {
        public string whoWin;

        private int[] goodWorth = { 1, 2, 3, 3, 4, 10 };
        private int[] evilWorth = {1, 2, 2, 2, 3, 5 ,10 };

        public GoodOrEvil(string str1, string str2)
        {
            //Regex() regex = new Regex();
            string[] arr1 = Regex.Split(str1, " +");
            string[] arr2 = Regex.Split(str2, " +");

            int goodScore = 0;
            int evilScore = 0;
            for (int i = 0; i<arr1.Length; i++)
            {
                goodScore += Convert.ToInt32(arr1[i]) * goodWorth[i];
            }

            for (int i = 0; i<arr2.Length; i++)
            {
                evilScore += Convert.ToInt32(arr2[i]) * evilWorth[i];
            
            }
           
            if (evilScore > goodScore)
            {
                whoWin = "Battle Result: Evil eradicates all trace of Good";
            }
            if (evilScore < goodScore)
            {
                whoWin = "Battle Result: Good triumphs over Evil";
            }
            if (evilScore == goodScore)
            {
                whoWin = "Battle Result: No victor on this battle field";
            }
            
        }
    }
}
