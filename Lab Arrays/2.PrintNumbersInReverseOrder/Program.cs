namespace _2.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             3
            10
            20
            30
             */

            //Input
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] += int.Parse(Console.ReadLine());
            }

            //Print the array in reversed order.
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]+ " ");                
            }
        }
    }
}