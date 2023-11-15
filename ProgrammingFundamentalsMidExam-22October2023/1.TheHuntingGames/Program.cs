namespace _1.TheHuntingGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerPerson = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());

            double totalWater = days * playersCount * waterPerPerson;
            double totalFood = days * playersCount * foodPerPerson;

            for (int day = 1; day <= days; day++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                groupEnergy -= energyLoss;

                if (groupEnergy <= 0)
                {
                    Console.WriteLine(
                        $"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
                    return;
                }

                if (day % 2 == 0)
                {
                    double waterDrank = 0.30 * totalWater;
                    totalWater -= waterDrank;
                    groupEnergy *= 1.05;
                }

                if (day % 3 == 0)
                {
                    double foodEaten = totalFood / playersCount;
                    totalFood -= foodEaten;
                    groupEnergy *= 1.10;
                }
            }

            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with {groupEnergy:F2} energy!");
            }
        }
    }
}