using AOC2024;
using AOC2024.ListOfLists;

var list = TransformFileTolinesOfIntegers
    .Execute("input.txt")
    .Rotate();

list[0] = list[0].OrderBy(x => x).ToList();
list[1] = list[1].OrderBy(x => x).ToList();

var sum = 0;
for(int i = 0; i < list[0].Count; i++)
{
    var a = list[0][i];
    var b = list[1][i];

    //Console.WriteLine(a + " " + b);

    sum += Math.Abs(a - b);
}

Console.WriteLine(sum);