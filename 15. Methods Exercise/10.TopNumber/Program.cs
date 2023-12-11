
namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int sum = 0;

                int d1 = (i / 10);
                //int d3 = (i / 10);
                int d2 = (i % 10);

                sum = d2 + d1;

                if (sum % 8 == 0)
                {
                    if (d1 % 2 != 0 || d2 % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
