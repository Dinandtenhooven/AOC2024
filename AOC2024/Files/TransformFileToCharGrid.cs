using AOC2024.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024.Files;
public static class TransformFileToCharGrid
{
    public static CharGrid Execute(string fileLocation)
    {
        var lines = File.ReadAllLines(fileLocation)
            .ToList();

        var xSize = lines[0].Length;
        var ySize = lines.Count;

        var chargrid = new CharGrid(xSize, ySize);

        FillCharGrid(lines, xSize, ySize, chargrid);

        return chargrid;
    }

    private static void FillCharGrid(List<string> lines, int xSize, int ySize, CharGrid chargrid)
    {
        for (var y = 0; y < ySize; y++)
        {
            for (var x = 0; x < xSize; x++)
            {
                var ch = lines[y][x];
                chargrid.SetValue(x, y, ch);
            }
        }
    }
}
