namespace _9.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             int
             2
             16
             char
             a
             z
             string
             aaa
             bbb               
             */
            string input = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            
            switch (input)
            {
                case "int":
                    int firstInt = int.Parse(input1);
                    int secondInt = int.Parse(input2);
                    int resultInt = GetMax(firstInt, secondInt);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char firstChar = char.Parse(input1);
                    char secondChar = char.Parse(input2);
                    char resultCh = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultCh);
                    break;
                case "string":
                    string firstStr = input1;
                    string secondStr = input2;
                    string resultStr = GetMax(firstStr, secondStr);
                    Console.WriteLine(resultStr);
                    break;
            }
        }

        static string GetMax(string a, string b)
        {
            return string.Compare(a, b) > 0 ? a : b;
        }

        static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }

        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}