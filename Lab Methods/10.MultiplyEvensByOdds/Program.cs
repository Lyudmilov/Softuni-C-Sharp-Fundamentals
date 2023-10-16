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