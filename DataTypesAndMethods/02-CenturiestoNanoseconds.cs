using System;
class Program
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        uint years = n * 100;
        ulong days = (ulong)(years * 365.2422);
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        decimal milliseconds = seconds * 1000;
        decimal microseconds = milliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;
        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", n, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
    }
}
