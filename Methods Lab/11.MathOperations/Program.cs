namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

           Console.WriteLine(CalculateOperation(num1, num2, sign));

        }

        static int CalculateOperation(int n1, int n2, char s)
        {
            int result = 0;

            switch (s)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
            }

            return result;
        }
    }
}
