namespace _4.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);

        }

        private static void PrintTriangle(int n)
        {
            PrintFirstHalfOfTriangle(n);
            PrintSecondHalfOfTriangle(n);
        }

        private static void PrintSecondHalfOfTriangle(int n)
        {
            for (int rol = n - 1; rol >= 1; rol--)
            {
                PrintColumn(rol);

                Console.WriteLine();
            }
        }

        private static void PrintFirstHalfOfTriangle(int n)
        {
            for (int rol = 1; rol <= n; rol++)
            {
                PrintColumn(rol);

                Console.WriteLine();
            }
        }

        private static void PrintColumn(int rol)
        {
            for (int col = 1; col <= rol; col++)
            {
                Console.Write(col + " ");
            }
        }
    }
}