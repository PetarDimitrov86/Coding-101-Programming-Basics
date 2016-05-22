using System;
using System.Linq;
class ShortWordsSorted
{
    static void Main(string[] args)
    {
        char[] separator = ".,:;()[]\"'!? ".ToArray();
        string[] words = Console.ReadLine().ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var result = words.Where(x => x.Length < 5).Distinct().OrderBy(x => x);
        Console.WriteLine(string.Join(", ", result));
    }
}
