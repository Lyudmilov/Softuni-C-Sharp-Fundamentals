namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            string age = Console.ReadLine();
            Console.WriteLine("Enter town");
            string town = Console.ReadLine();
            Console.WriteLine($"I am {firstName} {lastName}");
            Console.WriteLine($"{age}years old from {town}");
        }
    }
}
