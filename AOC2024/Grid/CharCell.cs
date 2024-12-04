using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024.Grid;
public class CharCell
{
    public char Value;
    public int X;
    public int Y;

    public CharCell(int x, int y)
    {
        X = x;
        Y = y;
    }

    public CharCell(int x, int y, char ch) : this(x, y)
    {
        Value = ch;
    }

    public void SetValue(char ch)
    {
        Value = ch;
    }
}
