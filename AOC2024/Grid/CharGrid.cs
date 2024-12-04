
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024.Grid;
public class CharGrid
{
    private int XSize;
    private int YSize;

    List<List<CharCell>> Grid;

    public CharGrid(int xSize, int ySize)
    {
        XSize = xSize;
        YSize = ySize;

        Grid = Enumerable.Range(0, YSize)
            .Select(y =>
            {
                return Enumerable.Range(0, XSize)
                    .Select(x => new CharCell(x, y))
                    .ToList();
            }).ToList();
    }

    public List<CharCell> FindAllCellsWith(char value)
    {
        return GetAllCells()
            .Where(c => c.Value == value)
            .ToList();
    }

    public IEnumerable<CharCell> GetAllCells()
    {
        foreach (var row in Grid)
        {
            foreach (var cell in row)
            {
                yield return cell; // Yield each cell one by one
            }
        }
    }

    public List<string> GetWordsInEightDirections(CharCell cell, int length)
    {
        return new List<string>
        {
            GetWordInDirection(cell, length,  1,  0),
            GetWordInDirection(cell, length,  1, -1),
            GetWordInDirection(cell, length,  0,  -1),
            GetWordInDirection(cell, length, -1,  -1),
            GetWordInDirection(cell, length, -1,  0),
            GetWordInDirection(cell, length, -1,  1),
            GetWordInDirection(cell, length,  0,  1),
            GetWordInDirection(cell, length,  1,  1)
        };
    }
    public string GetWordInDirection(CharCell cell, int length, int deltaX, int deltaY)
    {
        return GetWordInDirection(cell.X, cell.Y, length, deltaX, deltaY);
    }

    public string GetWordInDirection(int x, int y, int length, int deltaX, int deltaY)
    {
        var str = "";
        try
        {
            for (int i = 0; i < length; i++)
            {
                str += GetValue(x, y);
                x += deltaX;
                y += deltaY;
            }

        }
        catch(ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("expected");             
        }

        return str;
    }

    public char GetValue(int x, int y)
    {
        return Grid[y][x].Value;
    }

    public void SetValue(int x, int y, char ch)
    {
        Grid[y][x].SetValue(ch);
    }

    public int CountStamps(GridStamp gridStamp)
    {
        var maxX = XSize - gridStamp.MaxX;
        var maxY = YSize - gridStamp.MaxY;
        var count = 0;

        for(int y = 0; y < maxY; y++)
        {
            for(int x = 0; x < maxX; x++)
            {
                var isValid = true;

                foreach(var charcell in gridStamp.Cells)
                {
                    var posX = x + charcell.X;
                    var posY = y + charcell.Y;

                    if(GetValue(posX, posY) != charcell.Value)
                    {
                        isValid = false; 
                        break;
                    }
                }

                if(isValid)
                {
                    count++;
                }
            }
        }

        return count;
    }
}
