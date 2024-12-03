using System.Text.RegularExpressions;

var regex = "mul\\(\\d+,\\d+\\)";
var numberRegex = "\\d+";

var input = File.ReadAllText("input.txt");

var matches = Regex.Matches(input, regex);

var sum = 0;

foreach (Match match in matches)
{
    var str = match.Value;
    var numbers = Regex.Matches(str, numberRegex).ToList();

    var a = int.Parse(numbers[0].Value);
    var b = int.Parse(numbers[1].Value);

    sum += a * b;
}

Console.WriteLine(sum);