using System;
class Volleyball
{
    static void Main(string[] args)
    {
        string year = Console.ReadLine();
        int celebrations = int.Parse(Console.ReadLine());
        int homeWeekend = int.Parse(Console.ReadLine());
        double numberGames = 0.0d;
        int weekends = 48 - homeWeekend;

        if (year == "normal")
            numberGames = ((0.75 * weekends) + ((2.0 / 3.0) * celebrations) + homeWeekend);
        else if (year == "leap")
        {
            numberGames = ((0.75 * weekends) + ((2.0 / 3.0) * celebrations) + homeWeekend);
            numberGames = 0.15 * numberGames + numberGames;
        }
        Console.WriteLine("{0}", Math.Truncate(numberGames));
    }
}