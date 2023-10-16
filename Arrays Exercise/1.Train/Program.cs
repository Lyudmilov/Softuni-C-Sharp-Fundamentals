using System.Diagnostics.CodeAnalysis;

namespace _1.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] peopleInWagon = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagon[i];
            }

            Console.WriteLine(string.Join(" ", peopleInWagon));
            Console.WriteLine(sum);
        }
    }
}