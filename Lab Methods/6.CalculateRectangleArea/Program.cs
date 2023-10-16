namespace _6.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateRectangleArea(w, h));
            
        }

        private static double CalculateRectangleArea(double w, double h)
        {
            return w * h;
        }
    }
}