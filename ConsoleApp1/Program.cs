using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{


    class Program
    {
        static void Main()
        {
            //Task5 task5 = new Task5();
            //string result = task5.M1("av c vc");
            /*int a = 3;
            int b = 5;
            int c = 40;
            int d = c-- - b * a;    // a=3  b=5  c=39  d=25
            Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");
            */

            /* string sz = "101 60 52 11 25";
             string[] weights = Regex.Split(sz, " +");// вес по человечески
             string output = "";

             List<sWeight> wList = new List<sWeight>();
             for (int i =0; i<weights.Length; i++)
             {
                 wList.Add(new sWeight(weights[i]));

             }
             var selectedTeams = from t in wList orderby t.mWeight, t.weight  select t;
             foreach (sWeight ss in selectedTeams)
             {
                 output += ss.weight+" ";
                 Console.WriteLine(ss.weight);
             }
             output = output.TrimEnd();
             Console.WriteLine(output);
             //Console.WriteLine(sWeight sW in selectedTeams);
             */
            /*var selectedTeams = from t in teams // определяем каждый объект из teams как t
                                where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                                orderby t  // упорядочиваем по возрастанию
                                select t; // выбираем объект

            foreach (string s in selectedTeams)
                Console.WriteLine(s);
                */
            string[] str1 = { ":)", ":(", ":D", ":O", ":;" };
            SmileFaces w1 = new SmileFaces(str1);

            Console.WriteLine(w1.count);
            string str = "sdfaaaaaaaasdfdsfdsleiooOOOiI";
            string[] vowels = { "a", "e", "i", "o", "u" };

            foreach (string c in vowels)
            {
                str = str.Replace(c, "");
            }
            Console.WriteLine(str);


            long p = 269045;
            SmallestNumber PN = new SmallestNumber();


            PN.Method(p);

            Console.ReadKey();



        }

    }
    class Inverse
    {
        public Boolean M1()
        {
            int[] arr = { 1, 10, 3, 4, 10, 6 };
            int[] sqArr = { 1, 100, 19, 16, 100, 136 };

            int length = arr.Length;
            int[] tempArr = new int[length];
            Boolean mBool = false;

            for (int i = 0; i < length; i++)
            {
                tempArr[i] = arr[i] * arr[i];
            }
            for (int i = 0; i < length; i++)
            {
                mBool = false;
                for (int j = 0; j < length; j++)
                {
                    if (tempArr[i] == sqArr[j])
                    {
                        sqArr[j] = -1;
                        mBool = true;
                        break;
                    }

                }
                if (!mBool)
                {
                    Console.WriteLine("falseeeee");
                    for (int c = 0; c < length; c++)
                    {
                        Console.Write(sqArr[c] + " ");
                    }
                    return false;
                }
            }
            Console.WriteLine("truuuu");
            for (int i = 0; i < length; i++)
            {
                Console.Write(tempArr[i] + " ");
            }
            return true;

        }
    }
    class Func
    {
        public static int seq;
        public int SequenceSum(int start, int end, int step)
        {
            if (start > end)
            {
                return 0;
            }
            int nextElement = start;
            int sum = start;
            while (end >= (nextElement + step))
            {
                nextElement = nextElement + step;
                sum = sum + nextElement;
                Console.WriteLine(nextElement);

            }
            return sum;
        }

        public static string StringReverser(string str) {
            string regExpression = @"\s+";
            Regex regex = new Regex(regExpression);
            string[] resultStr = regex.Split(str);

            StringBuilder strBuilder = new StringBuilder();
            string resultStr2 = "";

            foreach (string index in resultStr)
            {
                //Console.WriteLine(index);
                for (int i = 0; i < index.Length; i++)
                {
                    strBuilder = strBuilder.Append(index[index.Length - (i + 1)]);
                }
                strBuilder = strBuilder.Append(" ");
            }
            resultStr2 = strBuilder.ToString();
            Console.WriteLine(resultStr2);

            return resultStr2;
        }
        public static string SongDecoder(string input)
        {
            string resultString;
            Regex regEx = new Regex("(WUB)+");
            resultString = regEx.Replace(input, " ");


            resultString = Regex.Replace(resultString, @"^[\s]", "");
            resultString = Regex.Replace(resultString, @"[\s]$", "");

            Console.WriteLine(resultString);
            return resultString;
        }

        public static int Vowels(string input)
        {
            int output = 0;
            string[] vowels = new string[] { "a", "e", "i", "o", "u" };
            foreach (string vowel in vowels)
            {
                Regex regEx = new Regex(vowel);

                MatchCollection matches = regEx.Matches(input);
                foreach (Match match in matches)
                {
                    ++output;
                }

                Console.WriteLine(output);
            }


            return output;
            //We will consider a, e, i, o, and u as vowels for this Kata.
        }



        public static string Tickets(int[] peopleInLine)
        {
            int cassa = 0;
            int bill25 = 0;
            int bill50 = 0;
            int bill100 = 0;


            for (int i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] - 25 > cassa)
                {
                    return "NO";
                }


                if (peopleInLine[i] == 25)
                {
                    ++bill25;
                }

                if (peopleInLine[i] == 50)
                {
                    ++bill50;
                    --bill25;
                }

                if (peopleInLine[i] == 100)
                {
                    if (bill50 > 0 & bill25 > 0)
                    {
                        --bill50;
                        --bill25;
                        ++bill100;
                    }
                    else
                        if (bill25 > 2)
                    {
                        bill25 = bill25 - 3;
                        ++bill100;
                    }
                    else
                        return "NO";
                }


                cassa = cassa + 25;
                //cassa = cassa + peopleInLine[i]
                //if (peopleInLine[i] = 25){
                //++25bill;
            }

            return "YES";
            //Your code is here...
        }

        public static string orderWeight(string input)
        {

            string output = "";
            string[] weights = Regex.Split(input, " +");// вес по человечески

            int[,] weightsWeights = new int[weights.Length - 1, 3]; //вес по человечески, вес по новому, индекс



            /*foreach (string s in weights)
            {
                Console.WriteLine(s);
            }*/

            for (int i = 1; i < weights.Length; i++)
            {
                //Console.WriteLine("|"+weights[i]+"|");
                int tempW = 0;
                weightsWeights[i - 1, 0] = Convert.ToInt32(weights[i]);
                weightsWeights[i - 1, 1] = i; //индекс

                for (int j = 0; j < weights[i].Length; j++) //считаю новый ВЕС
                {
                    string t = weights[i];
                    tempW += t[j] - '0';
                    //Console.WriteLine(t[j]);
                    //Console.WriteLine(Convert.ToInt16(t[j]));
                    //Console.WriteLine(tempW + "wwwwwwwwww");
                }
                Console.WriteLine(tempW + " mass");
                weightsWeights[i - 1, 2] = tempW;

            }

            /*var selectedTeams = from t in teams // определяем каждый объект из teams как t
                                where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                                orderby t  // упорядочиваем по возрастанию
                                select t; // выбираем объект

            foreach (string s in selectedTeams)
                Console.WriteLine(s);*/

            //var selectedTeams = from t in weightsWeights[1, i] orderby t select t;

            foreach (int s in weightsWeights)
            {
                Console.WriteLine(s);
            }


            return output;
        }
    }
}
    