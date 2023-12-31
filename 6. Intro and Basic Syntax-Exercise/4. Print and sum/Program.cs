﻿namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4. Print and Sum
             You will receive two whole numbers from the console representing the start and the end of a
             sequence of numbers.
             Your task is to print two lines:
             • On the first line, print all numbers from the start of the sequence to the end inclusive.
             • On the second line, print the sum of the sequence in the format: "Sum: {sum}".
             Examples
             Input Output
             5
             10
                   5 6 7 8 9 10
                   Sum: 45
             0
             26
                   0 1 2 … 26
                   Sum: 351            
             50
             60
                   50 51 52 53 54 55 56 57 58 59 60
                   Sum: 605 
             */

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}