using System;

namespace _6.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             1 2 3 2 1
             1 2
             1 2 3
             10 5 5 99 3 4 2 5 1 1 4               
             */
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            int index = -1;

            for (int i = 0; i < num.Length; i++)
            {
                for (int left = 0; left < i; left++)
                {
                    sumLeft += num[left];
                }

                for (int right = i + 1; right < num.Length; right++)
                {
                    sumRight += num[right];
                }

                if (sumLeft == sumRight)
                {
                    index = i;
                }
                sumLeft = 0;
                sumRight = 0;
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");

            }
        }
    }
}