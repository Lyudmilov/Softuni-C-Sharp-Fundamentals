namespace _3.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr1 = new string[n];
            string[] arr2 = new string[n];
            bool isFirst = true;
            
              /*
               4
               1 5
               9 10
               31 81
               41 20
               */
              //1 9 31 41
              //5 10 81 20
              //===>>
              //1 10 31 20
              //5 9 81 41
              for (int i = 0; i < n; i++)
              {
                  string input = Console.ReadLine();
                string[] inputStrings = input.Split();
                  if (isFirst)
                  {
                    arr1[i] = inputStrings[0];
                    arr2[i] = inputStrings[1];
                  }
                  else 
                  {
                      arr1[i] = inputStrings[1];
                      arr2[i] = inputStrings[0];
                  }
                  isFirst = !isFirst;
              }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}