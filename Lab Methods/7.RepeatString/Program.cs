namespace _7.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            PrintInput(n, input);
        }

        static string PrintInput(int n, string str)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result = str;
                Console.Write(result);
            }
            return result;
        }
    }
}