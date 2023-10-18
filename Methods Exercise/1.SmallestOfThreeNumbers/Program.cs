using System;
using System.Net.WebSockets;

namespace _1.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = PrintSmallestInt();
            Console.WriteLine(num.Min());
        }

        static List<int> PrintSmallestInt()
        {
            List<int> num = new List<int>();

            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out int nums))
                {
                    num.Add(nums);
                }
                else
                {
                    break;
                }
            }

            return num;
        }
    }
}