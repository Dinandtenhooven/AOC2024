using AOC2024.Files;
using System.Collections.Concurrent;

var lines = TransformFileToLines.Execute("input.txt");

var cut = lines.IndexOf("");

var instructions = lines.Take(cut - 1).ToList();
var orderings = lines.Skip(cut + 1).ToList();

var set = new Dictionary<string, string>();

foreach (var line in instructions)
{
    set.Add(line, line);
}

var incorrectLines = new List<string>();
foreach (var line in orderings)
{
    var numbers = line.Split(',').ToList();
    if (Check(numbers) == false)
    {
        incorrectLines.Add(line);
    }
}


var correctedLines = new ConcurrentBag<string>();
foreach(var line in incorrectLines)
{
    var numbers = new Queue<string>(line.Split(","));

    var newOrder = new List<string>();
    newOrder.Add(numbers.Dequeue());

    while (numbers.Count > 0)
    {
        var nextNumber = numbers.Dequeue();
        var found = false;

        for (int i = 0; i <= newOrder.Count; i++)
        {
            var newPossibility = newOrder.Take(i).ToList();
            newPossibility.Add(nextNumber);
            newPossibility.AddRange(newOrder.Skip(i).ToList());

            if (Check(newPossibility.ToList()))
            {
                newOrder = newPossibility.ToList();
                found = true;
                break;
            }
        }

        if (found == false)
        {
            numbers.Enqueue(nextNumber);
        }
    }

    correctedLines.Add(string.Join(",", newOrder));
}

var sum = 0;
foreach (var line in correctedLines)
{
    var numbers = line.Split(',');
    var middle = numbers.Length / 2;

    var value = int.Parse(numbers[middle]);
    sum += value;
}


Console.WriteLine(sum);


bool Check(List<string> numbers)
{
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        var a = numbers[i];
        var b = numbers[i + 1];
        var key = $"{a}|{b}";

        if (set.ContainsKey(key) == false)
        {
            return false;
        }
    }

    return true;
}

