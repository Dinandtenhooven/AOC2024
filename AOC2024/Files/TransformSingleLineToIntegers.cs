using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024;
public static class TransformSingleLineToIntegers
{
    public static List<int> Execute(string fileLocation)
    {
        return File.ReadAllText(fileLocation)
            .Split(new char[] { ',' })
            .Select(int.Parse)
            .ToList();
    }

}
