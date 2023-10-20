namespace _3.Problem3_MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               52 74 23 44 96 110
               Shoot 5 10
               Shoot 1 80
               Strike 2 1
               Add 22 3
               End

               52 74 23 44 96 110
               Shoot 5 10
               Shoot 1 80
               Strike 4 3
               Add 22 3
               End

               1 2 3 4 5
               Strike 0 1
               End               
            */
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string comands = "";
            while ((comands = Console.ReadLine()) != "End")
            {
                List<string> inputValues = comands
                    .Split()
                    .ToList();
                string comand = inputValues[0];
                int index = int.Parse(inputValues[1]);
                int value = int.Parse(inputValues[2]);

                if (index >= 0 && index <= targets.Count)
                {
                    if (comand == "Shoot")
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                    else if (comand == "Add")
                    {
                        targets.Insert(index, value);
                    }
                    else if (comand == "Strike")
                    {
                        if (index >= (value - index) && index < (value + index))
                        {
                            //Console.WriteLine($"index - {value}: {index - value}, index: {index}, index + {value}:{(value + index)}");
                            targets.RemoveRange((index - value), 2 * value + 1);
                        }
                        else if (index < (value - index)
                                 && index > (value + index))
                        {
                            Console.WriteLine("Strike missed!");
                        }
                    }
                }
                else
                {
                    if (comand == "Add")
                    {
                        if (index < 0 || index > targets.Count)
                        {
                            Console.WriteLine("Invalid placement!");
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}