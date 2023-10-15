namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             a b c d e
            -1 hi ho w

             */
            string[] letter = Console.ReadLine().Split(' ');

            for (int i = letter.Length - 1; i >= 0; i--)
            {
                Console.Write(letter[i] + ' ');
            }
        }
    }
}