namespace test
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopNumbers(n);
        }

        //PrintTop
        static void PrintTopNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            return SumOfDigitsIsDivisibleBy8(number) && ContainsOddDigit(number);
        }

        static bool SumOfDigitsIsDivisibleBy8(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                {
                    sum += number % 10;
                    number /= 10;
                }
            }

            return sum % 8 == 0;
        }


        static bool ContainsOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }
            //ret
            return false;
        }
    }
}
