namespace _7.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        private static void PrintMatrix(int n)
        {
            for (int roll = 0; roll < n; roll++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
