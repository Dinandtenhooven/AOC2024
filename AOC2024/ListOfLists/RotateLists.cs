using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2024.ListOfLists;
public static class RotateLists
{
    public static List<List<T>> Rotate<T>(this List<List<T>> lists)
    {
        var count = lists[0].Count;

        var newLists = Enumerable.Range(0, count)
            .Select(i => new List<T>())
            .ToList();

        for( var i = 0; i < lists.Count; i++)
        {
            for(var j = 0; j < count; j++)
            {
                newLists[j].Add(lists[i][j]);
            }
        }

        return newLists;
    }

}
