using System;
class TimePlus15Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        TimeSpan tms = new TimeSpan(hours, min + 15, 0);
        Console.WriteLine("{0:%h}:{0:mm}", tms);
    }
}