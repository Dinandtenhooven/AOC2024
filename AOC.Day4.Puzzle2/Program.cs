using AOC2024.Files;
using AOC2024.Grid;

var grid = TransformFileToCharGrid.Execute("input.txt");

var version1 = grid.CountStamps(new GridStamp(
    new CharCell(0, 0, 'M'),
    new CharCell(2, 0, 'M'),
    new CharCell(1, 1, 'A'),
    new CharCell(2, 2, 'S'),
    new CharCell(0, 2, 'S')
));

var version2 = grid.CountStamps(new GridStamp(
    new CharCell(0, 0, 'S'),
    new CharCell(2, 0, 'M'),
    new CharCell(1, 1, 'A'),
    new CharCell(2, 2, 'M'),
    new CharCell(0, 2, 'S')
));

var version3 = grid.CountStamps(new GridStamp(
    new CharCell(0, 0, 'S'),
    new CharCell(2, 0, 'S'),
    new CharCell(1, 1, 'A'),
    new CharCell(2, 2, 'M'),
    new CharCell(0, 2, 'M')
));

var version4 = grid.CountStamps(new GridStamp(
    new CharCell(0, 0, 'M'),
    new CharCell(2, 0, 'S'),
    new CharCell(1, 1, 'A'),
    new CharCell(2, 2, 'S'),
    new CharCell(0, 2, 'M')
));

Console.WriteLine(version1);
Console.WriteLine(version2);
Console.WriteLine(version3);
Console.WriteLine(version4);
Console.WriteLine(version1 + version2 + version3 + version4);

