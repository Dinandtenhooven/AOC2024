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

    var safe = true;
    for (var i = 0; i < line.Count - 1; i++)
    {
        var first = line[i];
        var second = line[i + 1];

        if (first >= second)
        {
            safe = false;
            break;
        }

        if (second - first >= 4)
        {
            safe = false;
            break;
        }

    }

    if (safe)
    {
        count++;
    }
}

Console.WriteLine("count:" + count);
