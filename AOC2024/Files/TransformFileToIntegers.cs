using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024;
public static class TransformFileToIntegers
{
    public static List<int> Execute(string fileLocation)
    {
        return File.ReadAllLines(fileLocation)
            .Select(int.Parse)
            .ToList();
    }

}
