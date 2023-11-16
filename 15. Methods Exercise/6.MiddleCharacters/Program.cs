namespace _6.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            MiddleIndex(word);
        }

        private static void MiddleIndex(string? word)
        {
            int middleIndex = word.Length / 2;


            if (word.Length % 2 == 0)
            {
                Console.Write($"{word[middleIndex - 1]}{word[middleIndex]}");
            }
            else
            {
                Console.Write($"{word[middleIndex]}");
            }
        }
    }
}
