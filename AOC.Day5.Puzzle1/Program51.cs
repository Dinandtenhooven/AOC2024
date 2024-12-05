

using AOC2024.Files;

var lines = TransformFileToLines.Execute("input.txt");

var cut = lines.IndexOf("");

var instructions = lines.Take(cut - 1).ToList();
var orderings = lines.Skip(cut + 1).ToList();

var set = new Dictionary<string, string>();

foreach (var line in instructions)
{
    set.Add(line, line);
}

var correctLines = new List<string>();

foreach (var line in orderings)
{
    var numbers = line.Split(',');
    var isValid = true;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        var a = numbers[i];
        var b = numbers[i + 1];
        var key = $"{a}|{b}";

        if (set.ContainsKey(key) == false)
        {
            isValid = false;
            break;
        }
    }

    if (isValid)
    {
        correctLines.Add(line);
    }
}

var sum = 0;

foreach (var line in correctLines)
{
    var numbers = line.Split(',');
    var middle = numbers.Length / 2;

    var value = int.Parse(numbers[middle]);
    sum += value;
}


Console.WriteLine(sum);