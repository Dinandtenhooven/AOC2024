using AOC2024.Files;

var grid = TransformFileToCharGrid.Execute("input.txt");

var allCellsWithX = grid.FindAllCellsWith('M');

var totalCount = 0;
foreach (var cell in allCellsWithX)
{
    var words = grid.GetWordsInEightDirections(cell, 4);
    var wordcount = words.Count(s => s.Equals("XMAS"));

    totalCount += wordcount;
}


Console.WriteLine(totalCount);
