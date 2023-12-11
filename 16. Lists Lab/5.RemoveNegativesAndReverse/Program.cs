
List<int> num = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> num1 = new List<int>();

//10 -5 7 9 -33 50
//50 9 7 10

for (int i = 0; i < num.Count; i++)
{
    /*if (num[i] >= 0)
    {
        num1.Add(num[i]);
        *//*if (num.Contains(num[i] < 0))
        {
            Console.WriteLine("empty");
        }*//*
    }
    else
    {*/
    num.RemoveAll(x => x < 0);

    if (num.Count == 0)
    {
        Console.WriteLine("empty");
    }
    //}
}

//num.Sort();
num.Reverse();

Console.WriteLine(string.Join(" ", num));
