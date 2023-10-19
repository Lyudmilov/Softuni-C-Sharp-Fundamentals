namespace _8.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(PrintMathPower(num1, num2));
            
        }

        private static double PrintMathPower(double num1, double num2)
        {
            double result = Math.Pow(num1, num2);
            return result;
        }
    }
}