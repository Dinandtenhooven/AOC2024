using AOC2024;
using AOC2024.ListOfLists;

var list = TransformFileTolinesOfIntegers
    .Execute("input.txt")
    .Rotate();

var origin = list[0].OrderBy(x => x).ToList();
var checklist = list[1];

var checkdict = new Dictionary<int, int>();
foreach (var item in checklist)
{
    if (checkdict.ContainsKey(item) == false)
    {
        checkdict[item] = 0;
    }

    checkdict[item]++;
}

var sum = 0;
for (int i = 0; i < origin.Count; i++)
{
    var a = origin[i];
    if (checkdict.TryGetValue(a, out var b))
    {
        sum += a * b;
    }
}

Console.WriteLine(sum);