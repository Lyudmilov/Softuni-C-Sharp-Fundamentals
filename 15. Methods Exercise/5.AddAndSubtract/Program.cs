namespace _5.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);

            Console.WriteLine($"{Substract(sum, c)}");
        }

        private static int Substract(int sum, int c)
        {
            int sub = sum - c;
            return sub;
        }

        private static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}