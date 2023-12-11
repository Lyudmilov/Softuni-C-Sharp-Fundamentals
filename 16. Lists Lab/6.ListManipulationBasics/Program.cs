/* 4 19 2 53 6 43
   Add 3
   Remove 2
   RemoveAt 1
   Insert 8 3
   end
   */

List<int> num = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<string> input = Console.ReadLine().Split().ToList();

string command = input[0];
string number = input[1];
    string index = string.Empty;

while (command != "end")
{
    if (command == "Add")
    {
        input.Add(number);
    }
    else if (command == "Remove")
    {
        input.Remove(number);
    }
    else if (command == "RemoveAt")
    {
        input.RemoveAt(int.Parse(number));
    }
    else if (command == "Insert")
    {
        input.Insert(int.Parse(number), index);
    }

    input = Console.ReadLine().Split().ToList();
    if (input.Count > 1)
    {
    index = input[2];
        
    }

}

Console.WriteLine(string.Join(" ", input));
