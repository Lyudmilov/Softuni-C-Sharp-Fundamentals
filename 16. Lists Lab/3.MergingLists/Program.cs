
List<int> num1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> num2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();

int minNum = Math.Min(num1.Count, num2.Count);

for (int i = 0; i < minNum; i++)
{
    result.Add(num1[i]);
    result.Add(num2[i]);

}

if (num1.Count > num2.Count)
{
    for (int i = minNum; i < num1.Count; i++)
    {
        result.Add(num1[i]);
    }
}
else if (num1.Count < num2.Count)
{
    for (int i = minNum; i < num2.Count; i++)
    {
        result.Add(num2[i]);
    }
}

Console.WriteLine(string.Join(" ", result));