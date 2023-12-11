using System.Linq;
using System.Runtime.CompilerServices;

int n = int.Parse(Console.ReadLine());

List<string> products = new List<string>();

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    products.Add(input);
    products.Sort();
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i + 1}.{products[i]}");
}


