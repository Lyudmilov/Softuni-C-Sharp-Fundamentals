using System.Diagnostics.CodeAnalysis;

namespace _2.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int sum = PrintVowelsCount(word);

            Console.WriteLine(sum);
        }

        private static int PrintVowelsCount(string word)
        {
            int sum = 0;
            

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'i':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'O':
                    case 'I':
                    case 'U':
                        sum++;
                        break;
                }
            }
            return sum;
        }
    }
}