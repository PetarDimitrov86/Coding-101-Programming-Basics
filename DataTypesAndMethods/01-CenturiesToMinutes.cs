using System;
class Program
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        uint years = n * 100;
        ulong days = (ulong) (years * 365.2422);
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", n, years, days, hours, minutes);
    }
}
