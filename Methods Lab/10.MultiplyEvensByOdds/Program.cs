using System.Diagnostics.CodeAnalysis;
using static System.Net.Mime.MediaTypeNames;
using Console = System.Console;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int multiplySumsEvenOdd = FindEvenSum(n) * FindOddSum(n);
            Console.WriteLine(multiplySumsEvenOdd);

            //Още един вариант на решение без методи
            /*
               string input = Console.ReadLine();
               int n = Math.Abs(int.Parse(input));
               string nStr = n.ToString();
               
               int[] num = new int[nStr.Length];
               
               for (int i = 0; i < nStr.Length; i++)
               {
               char currentChar = nStr[i];
               num[i] = int.Parse(currentChar.ToString());
               }
               
               int sumEven = 0;
               int sumOdd = 0;
               
               for (int i = 0; i < num.Length; i++)
               {
               if (num[i] % 2 == 0)
               {
               sumEven += num[i];
               }
               else
               {
               sumOdd += num[i];
               }
               }
               
               Console.WriteLine(sumEven * sumOdd);
             */
        }

        static int FindEvenSum(int num)
        {
            int sumEven = 0;

            while (num > 0)
            {
                int next = num % 10;

                /*if (next % 2 == 0)
                {
                    sumEven += next;
                }*/
                sumEven += next % 2 == 0 ? next : 0;

                num /= 10;
            }
            return sumEven;
        }

        static int FindOddSum(int num)
        {
            int sumOdd = 0;

            while (num > 0)
            {
                int next = num % 10;

                /*if (next % 2 == 0)
                {
                    sumOdd += next;
                }*/
                sumOdd += next % 2 != 0 ? next : 0;

                num /= 10;
            }
            return sumOdd;
        }
    }
}