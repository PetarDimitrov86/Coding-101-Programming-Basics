using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] date = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
        DateTime exactDate = new DateTime(date[2], date[1], date[0]);
        Console.WriteLine(exactDate.DayOfWeek);
    }
}