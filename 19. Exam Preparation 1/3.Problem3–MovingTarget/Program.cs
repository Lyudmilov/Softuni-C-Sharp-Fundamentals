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
                           
               1 2 3 4 5
               Strike 0 1
               End               
            */

            //Решение 100/100 (Разликата с другото решение че тук проверявам при всяка команда, дали подадените стойности влизат
            //в големината на масива, а при дугото решение първо проверявам дали влизат в масива и след това командите и се чупи някъде)
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

                if (comand == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (comand == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (comand == "Strike")
                {
                    if (index >= 0 && index < targets.Count && index - value >= 0 && index + value < targets.Count)
                    {
                         targets.RemoveRange((index - value), 2 * value + 1);
                       
                        //Съюотот решение но с цикъл
                        /* targets.RemoveAt(index);
                        //left
                        for (int i = 0; i < value; i++)
                        {
                            targets.RemoveAt(index + i);
                        }
                        //right
                        for (int i = 1; i <= value; i++)
                        {
                            targets.RemoveAt(index - i);
                        }*/
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }                              
            }
            Console.WriteLine(string.Join("|", targets));


            //Решение 80/100
            /* List<int> targets = Console.ReadLine()
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
                        //Console.WriteLine(string.Join("|", targets));
                    }
                    else if (comand == "Add")
                    {
                        targets.Insert(index, value);
                    }
                    else if (comand == "Strike")
                    {
                        if (index >= (value - index) && index < (value + index))
                        {
                            // също работи
                            //targets.RemoveRange((index - value), 2 * value + 1);
                            targets.RemoveAt(index);
                            //left
                            for (int i = 0; i < value; i++)
                            {
                                targets.RemoveAt(index + i);
                            }
                            //right
                            for (int i = 1; i <= value; i++)
                            {
                                targets.RemoveAt(index - i);
                            }
                        }
                        else if (index < (value - index)
                                 || index > (value + index))
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
            Console.WriteLine(string.Join("|", targets));*/
        }
    }
}