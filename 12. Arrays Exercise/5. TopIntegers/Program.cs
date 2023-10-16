namespace _5._TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*
           1 4 3 2
           14 24 3 19 15 17
           27 19 42 2 13 45 48             
           */
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < num.Length; i++)
            {
            bool isBigger = true;
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] <= num[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.WriteLine($"{num[i]} ");  
                }
            }
           
        }
    }
}