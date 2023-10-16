using System;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              10 20 30
              10 20 30

              1 2 3 4 5
              1 2 4 3 5

              1
              10
            */

            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool isEqual = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    sum += arr1[i];
                    isEqual = true;
                }
                else
                {

                    isEqual = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}