using System.ComponentModel;

namespace _2.Problem2_TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            15
            0 0 0 0

            20
            0 2 0
             */

            int people = int.Parse(Console.ReadLine());
            List<int> wagon = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            /*
             •	If there are still people in the queue and no more available space, you should print:
              Console.WriteLine($"There isn't enough space! {} people in a queue!");
              Console.WriteLine(string.Join(" ", ));

            •	If there are no more people and the lift has empty spots, you should print:
              Console.WriteLine("The lift has empty spots!");
              Console.WriteLine(string.Join(" ", ));

            •	If the lift is full and there are no more people in the queue,
              you should print only the wagons separated by " "
              Console.WriteLine(string.Join(" ", ));*/
            for (int i = 0; i < wagon.Count; i++)
            {
                int currWagon = wagon[i];

                if (currWagon < 4)
                {
                    int emptySeats = 4 - wagon[i];
                    people -= emptySeats;
                    if (people < 0)
                    {
                        wagon[i] = 4 - Math.Abs(people);
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", wagon));
                        return;
                    }
                    wagon[i] = 4;
                }
            }

            if (people != 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            Console.WriteLine(string.Join(" ", wagon));
        }
    }
}