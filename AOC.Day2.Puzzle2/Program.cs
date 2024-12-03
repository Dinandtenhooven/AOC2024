

using AOC2024;

var list = TransformFileTolinesOfIntegers
    .Execute("input.txt");

var count = 0;

foreach (var line in list)
{
    if (line.First() > line.Last())
    {
        line.Reverse();
    }

    if (CheckSafety(line))
    {
        count++;
        continue;
    }

    var saveWhenSkipped = 0;
    for (int i = 0; i < line.Count; i++)
    {
        var firstPart = line.Take(i).ToList();
        var secondPart = line.Skip(i + 1).ToList();
        firstPart.AddRange(secondPart.ToList());

        Console.WriteLine(string.Join(",", firstPart));

        if(CheckSafety(firstPart))
        {
            saveWhenSkipped++;
        }
    }

    if(saveWhenSkipped == 1 || saveWhenSkipped == 2) {
        count++;
    }
}

Console.WriteLine("count:" + count);

static bool CheckSafety(List<int> line)
{
    for (var i = 0; i < line.Count - 1; i++)
    {
        var first = line[i];
        var second = line[i + 1];

        if (first >= second)
        {
         
            return false;
        }

        if (second - first >= 4)
        {
            return false;
        }
    }

    return true;
}