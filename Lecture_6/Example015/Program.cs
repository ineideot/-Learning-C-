using System.Linq;

string text = "(2,2) (2,3) (4,5) (10,7)"
                            .Replace("(", "")
                            .Replace(")", "");
Console.WriteLine(text);
Console.WriteLine();

var data = text.Split(" ")
                .Select(item => item.Split(","))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x * 4, point.y + point.x))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}
