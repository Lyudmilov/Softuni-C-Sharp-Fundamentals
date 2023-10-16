namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3. Vacation
             You will receive three lines from the console:             
             • A count of people who are going on vacation.
             • Type of the group (Students, Business or Regular).
             • The day of the week which the group will stay on (Friday, Saturday or Sunday).
             Based on the given information calculate how much the group will pay for the entire vacation.
             The price for a single person is as follows:
                      Friday Saturday Sunday
             Students 8.45    9.80    10.46
             Business 10.90   15.60   16
             Regular  15      20      22.50
             There are also discounts based on some conditions:
             • For Students – if the group is 30 or more people, you should reduce the total price by 15%.
             • For Business – if the group is 100 or more people, 10 of the people stay for free.
             • For Regular – if the group is between 10 and 20 people (both inclusively), reduce the total 
             price by 5%.
             Note: You should reduce the prices in that EXACT order!
             As an output print the final price which the group is going to pay in the format:
             "Total price: {price}"
             The price should be formatted to the second decimal point.
             Examples
             Input      Output
             30
             Students
             Sunday
                        Total price: 266.73
             40
             Regular
             Saturday
                        Total price: 800.00
             */
            int count = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (group)
            {
                case "Students":
                    if (count >= 30)
                    {
                        if (day == "Friday")
                        {
                            price = (count * 8.45) * 0.85;
                        }
                        else if (day == "Saturday")
                        {
                            price = (count * 9.80) * 0.85;
                        }
                        else if (day == "Sunday")
                        {
                            price = (count * 10.46) * 0.85;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        if (day == "Friday")
                        {
                            price = (count * 8.45);
                        }
                        else if (day == "Saturday")
                        {
                            price = (count * 9.80);
                        }
                        else if (day == "Sunday")
                        {
                            price = (count * 10.46);
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
                case "Business":
                    if (count >= 100)
                    {
                        if (day == "Friday")
                        {
                            price = ((count - 10) * 10.90);
                        }
                        else if (day == "Saturday")
                        {
                            price = ((count - 10) * 15.60);
                        }
                        else if (day == "Sunday")
                        {
                            price = ((count - 10) * 16);
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        if (day == "Friday")
                        {
                            price = (count * 10.90);
                        }
                        else if (day == "Saturday")
                        {
                            price = (count * 15.60);
                        }
                        else if (day == "Sunday")
                        {
                            price = (count * 16);
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
                case "Regular":
                    if (count >= 10 && count <= 20)
                    {
                        if (day == "Friday")
                        {
                            price = (count * 15) * 0.95;
                        }
                        else if (day == "Saturday")
                        {
                            price = (count * 20) * 0.95;
                        }
                        else if (day == "Sunday")
                        {
                            price = (count * 22.50) * 0.95;
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    else
                    {
                        if (day == "Friday")
                        {
                            price = (count * 15);
                        }
                        else if (day == "Saturday")
                        {
                            price = (count * 20);
                        }
                        else if (day == "Sunday")
                        {
                            price = (count * 22.50);
                        }
                        Console.WriteLine($"Total price: {price:f2}");
                    }
                    break;
                   
            }
        }
    }
}