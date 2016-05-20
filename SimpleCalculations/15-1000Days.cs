using System;
using System.Globalization;
class ThousandDays
{
    static void Main()
    {
        var dateString = Console.ReadLine();
        var format = "dd-MM-yyyy";
        var provider = new CultureInfo("bg-BG");
        DateTime birthday = DateTime.ParseExact(dateString, format, provider);
        DateTime future = birthday.AddDays(999);
        Console.WriteLine(future.ToString(format));
    }
}