namespace _8.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            1 7 6 2 19 23
            8
            14 20 60 13 7 19 8
            27
            */
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] + num[j] == number)
                    {
                        Console.WriteLine($"{num[i]} {num[j]}");
                    }

                }
            }
        }
    }
}