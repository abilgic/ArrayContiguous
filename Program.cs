List<int> arr = new List<int> { 1, 2, 3, 4 };
var sublist = new List<List<int>>();

for (int length = 1; length < arr.Count; length++)
{
    for (int j = 0; j < arr.Count; j++)//Starting point
    {
        if (j + length <= arr.Count)
        {
            var res = arr.GetRange(j, length);
            sublist.Add(res);
        }
    }
}

foreach (var item in sublist)
{
    foreach (var sub in item)
    {
        Console.Write($"{sub} ");
    }
    Console.WriteLine();
}

