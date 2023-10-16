namespace _3.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             0.9 1.5 2.4 2.5 3.14
             */

            //INPUT
            /*
             Read an array of real numbers (space separated),
             round them in "away from 0"
            */
            double[] nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            /*
             * style and print the output as in the examples:
             0.9 => 1
             1.5 => 2
             2.4 => 2
             2.5 => 3
             3.14 => 3
             */
            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = (int) Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedNums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {roundedNums[i]}");
            }

        }
    }
}