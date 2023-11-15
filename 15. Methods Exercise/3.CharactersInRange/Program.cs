namespace _3.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            if (a > b)
            {
                char swapped = a;
                a = b; 
                b = swapped;
            }

            PrintBetween(a, b);
        }

        public static void PrintBetween(char a, char b)
        {
            for (int i = a + 1; i < b; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}