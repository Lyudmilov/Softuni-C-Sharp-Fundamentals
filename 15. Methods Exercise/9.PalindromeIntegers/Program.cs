namespace _9.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            int originalNumber = 0;

            int reversedNumber = 0;

            while ((input = Console.ReadLine()) != "END")
            {
                originalNumber = int.Parse(input);
                int tempNum = originalNumber;

                reversedNumber = 0;

                while (tempNum > 0)
                {
                    int remainder = tempNum % 10;
                    reversedNumber = reversedNumber * 10 + remainder;
                    tempNum = tempNum / 10;
                }

                bool isPalindrome = (originalNumber == reversedNumber);

                if (isPalindrome)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }

        }
    }
}
