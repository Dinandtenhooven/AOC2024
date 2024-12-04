using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024.Grid;
public class GridStamp
{
    public List<CharCell> Cells;

    public GridStamp(params CharCell[] cells) { 
        Cells = cells.ToList();
    }

    public int MaxX => Cells.Max(c => c.X);
    public int MaxY => Cells.Max(c => c.Y);


}
