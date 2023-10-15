namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2 1 1 2 3 3 2 2 2 1
             1 1 1 2 3 1 3 3
             4 4 4 4
             0 1 1 5 2 2 6 3 3               
             */

            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int currLen = 1;
            int maxLen = 1;
            int ellement = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] == num[i - 1])
                {
                    currLen++;

                    if (currLen > maxLen)
                    {
                        maxLen = currLen;
                        ellement = num[i];
                    }
                }
                else
                {
                    currLen = 1;
                }
            }

            for (int i = 0; i < maxLen; i++)
            {
                Console.Write($"{ellement} ");
            }

            /*int currLenght = 1;
            int maxLenght = 1;
            int element = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] == num[i - 1])
                {
                    currLenght++;
                    if (currLenght > maxLenght)
                    {
                        maxLenght = currLenght;
                        element = num[i];
                    }
                }
                else
                {
                    currLenght = 1;
                }
            }

            for (int i = 0; i < maxLenght; i++)
            {
                Console.Write(element + " ");
            }*/

            //int cur
        }
    }
}
