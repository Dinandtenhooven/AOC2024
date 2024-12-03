using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024.Files;
public static class TransformFileToLines
{
    public static List<string> Execute(string fileLocation)
    {
        return File.ReadAllLines(fileLocation)
            .ToList();
    }

}
