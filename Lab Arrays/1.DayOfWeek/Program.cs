namespace _1.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            //Enter a number in range 1-7 
            int day = int.Parse(Console.ReadLine());
            
            //Body (array) days
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //Print
            // the word representing it or "Invalid Day!".

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(weekDays[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*//Input
            //Enter a number in range 1-7 
            int input = int.Parse(Console.ReadLine());

            //Body (array) days
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //Print
            // the word representing it or "Invalid Day!".
            if (input >= 1 && input <= 7)
                Console.WriteLine(days[input - 1]);
            else
                Console.WriteLine("Invalid day!");*/
        }
    }
}