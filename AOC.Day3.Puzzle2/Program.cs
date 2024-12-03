using System.Text.RegularExpressions;

var regex = "mul\\(\\d+,\\d+\\)|don't\\(\\)|do\\(\\)";
var numberRegex = "\\d+";

var input = File.ReadAllText("input.txt");

var matches = Regex.Matches(input, regex);

var sum = 0;
var doing = true;

foreach (Match match in matches)
{
    var str = match.Value;
    if (str == "do()")
    {
        doing = true;
        continue;
    }
    else if(str == "don't()")
    {
        doing = false;
        continue;
    }

    if(doing)
    {
        var numbers = Regex.Matches(str, numberRegex).ToList();

        var a = int.Parse(numbers[0].Value);
        var b = int.Parse(numbers[1].Value);

        sum += a * b;
    }

    Console.WriteLine(str);
    Console.WriteLine(sum);
}

Console.WriteLine(sum);