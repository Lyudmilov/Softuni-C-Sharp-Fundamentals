namespace _8.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double result = DevidedTwoFactoriels(a, b);

            Console.WriteLine($"{result:f2}");
        }

        private static double DevidedTwoFactoriels(int a, int b)
        {
            double fac1 = 1;
            double fac2 = 1;

            double dev = 0;

            for (int i = 1; i <= a; i++)
            {
                fac1 *= i;
            }

            for (int i = 1; i <= b; i++)
            {
                fac2 *= i;
            }

            dev = fac1 / fac2;

            return dev;
        }
    }
}
