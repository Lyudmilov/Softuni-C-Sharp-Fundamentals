namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());


            for (int j = 0; j < n; j++)
            {
                int temp = nums[0];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }

                nums[nums.Length - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", nums));

        }
    }
}