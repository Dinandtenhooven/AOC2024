using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024;
public static class TransformFileTolinesOfIntegers
{
    public static List<List<int>> Execute(string fileLocation, char separator = ' ')
    {
        return File.ReadAllLines(fileLocation)
            .Select(x => GetList(x, separator))
            .ToList();
    }

    private static List<int> GetList(string line, char separator)
    {
        var list = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        return list.Select(int.Parse).ToList();
    }
}
