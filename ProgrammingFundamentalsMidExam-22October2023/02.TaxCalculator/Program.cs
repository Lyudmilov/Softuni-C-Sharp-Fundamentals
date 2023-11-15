namespace _02.TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> vehicles = Console.ReadLine()
               .Split(">>", StringSplitOptions.RemoveEmptyEntries)
               .ToList();
            int ttlTaxForAgency = 0;

            foreach (var vehicle in vehicles)
            {
                List<string> carInfo = vehicle.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string type = carInfo[0];
                int yearsToPay = int.Parse(carInfo[1]);
                int km = int.Parse(carInfo[2]);
                int kmTax = 0;
                int carTax = 0;

                switch (type)
                {
                    case "family":
                        kmTax = km / 3000;
                        carTax = kmTax * 12 + (50 - yearsToPay * 5);
                        ttlTaxForAgency += carTax;
                        Console.WriteLine($"A {type} car will pay {carTax:F2} euros in taxes.");
                        break;
                    case "heavyDuty":
                        kmTax = km / 9000;
                        carTax = kmTax * 14 + (80 - yearsToPay * 8);
                        ttlTaxForAgency += carTax;
                        Console.WriteLine($"A {type} car will pay {carTax:F2} euros in taxes.");
                        break;
                    case "sports":
                        kmTax = km / 2000;
                        carTax = kmTax * 18 + (100 - yearsToPay * 9);
                        ttlTaxForAgency += carTax;
                        Console.WriteLine($"A {type} car will pay {carTax:F2} euros in taxes.");
                        break;
                    default:
                        Console.WriteLine("Invalid car type.");
                        break;
                }
            }

            Console.WriteLine($"The National Revenue Agency will collect {ttlTaxForAgency:F2} euros in taxes.");

            /* List<string> vehicles = Console.ReadLine()
                      .Split(">>", StringSplitOptions.RemoveEmptyEntries)
                      .ToList();
             int familyCarTax = 0;
             int heavyDutyCarTax = 0;
             int sportsCarTax = 0;
             int total = 0;

             for (int i = 0; i < vehicles.Count; i++)
             {
                 List<string> carArgs = vehicles[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .ToList();
                 string carType = carArgs[0];
                 int yearsToPay = int.Parse(carArgs[1]);
                 int kilometers = int.Parse(carArgs[2]);

                 if (carType == "family")
                 {
                     int kilometersTax = kilometers / 3000;
                     familyCarTax = kilometersTax * 12 + (50 - yearsToPay * 5);
                     total += familyCarTax;
                     Console.WriteLine($"A {carType} car will pay {familyCarTax:F2} euros in taxes.");
                 }
                 else if (carType == "heavyDuty")
                 {
                     int kilometersTax = kilometers / 9000;
                     heavyDutyCarTax = kilometersTax * 14 + (80 - yearsToPay * 8);
                     total += heavyDutyCarTax;
                     Console.WriteLine($"A {carType} car will pay {heavyDutyCarTax:F2} euros in taxes.");
                 }
                 else if (carType == "sports")
                 {
                     int kilometersTax = kilometers / 2000;
                     sportsCarTax = kilometersTax * 18 + (100 - yearsToPay * 9);
                     total += sportsCarTax;
                     Console.WriteLine($"A {carType} car will pay {sportsCarTax:F2} euros in taxes.");
                 }
                 else
                 {
                     Console.WriteLine("Invalid car type.");
                 }
             }

             Console.WriteLine($"The National Revenue Agency will collect {total:F2} euros in taxes.");
         */

        }
    }
}