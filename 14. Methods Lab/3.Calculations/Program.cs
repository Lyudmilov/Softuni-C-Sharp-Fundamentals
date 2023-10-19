namespace _3.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             – "add", "multiply", "subtract", "divide"
             */
            /*
               subtract
               5
               4
               divide
               8
               4   
             */

            
            string mathOperation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            MathOperation(mathOperation, num1, num2);
        }

        private static void MathOperation(string mathOperation, int num1, int num2)
        {
            switch (mathOperation)
            {
                case "add":
                    Add(num1, num2);
                    break;
                case "multiply":
                    Multiply(num1, num2);
                    break;
                case "subtract":
                    Subtract(num1, num2);
                    break;
                case "divide":
                    Divide(num1, num2);
                    break;
            }
        }

        static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

    }
}