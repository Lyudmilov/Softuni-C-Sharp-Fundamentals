namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only its even
            //values. 

            /*
            1 2 3 4 5 6
            3 5 7 9
            2 4 6 8 10
            */
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sum += nums[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}