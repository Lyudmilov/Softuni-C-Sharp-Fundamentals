namespace _5.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*•	A string, representing a product - "coffee",
             "water", "coke", "snacks"*/
            /*
               •	coffee – 1.50
               •	water – 1.00
               •	coke – 1.40
               •	snacks – 2.00               
             */
            /*
               water
               5
               coffee
               2
               */

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
           
           PrintSum(product, quantity);
            
        }

        private static void PrintSum(string product, int quantity)
        {
            double sum = 0;
            
            switch (product)
            {
                case "coffee":
                    sum = quantity * 1.50;
                    break;
                case "water":
                    sum = quantity * 1.00;
                    break;
                case "coke":
                    sum = quantity * 1.40;
                    break;
                case "snacks":
                    sum = quantity * 2.00;
                    break;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}