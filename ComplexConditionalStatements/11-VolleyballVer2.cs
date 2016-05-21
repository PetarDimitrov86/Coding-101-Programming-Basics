using System;
class Volleyball
{
    static void Main(string[] args)
    {
        string year = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double homeHolidays = double.Parse(Console.ReadLine());
        double totalPlays = 0;
        double weeks = 48;
        double saturdaySofia = (weeks - homeHolidays) * 3 / 4;
        double holidaysSofia = holidays * 2 / 3;
        totalPlays = saturdaySofia + holidaysSofia + homeHolidays;

        if (year == "leap")
            totalPlays += (0.15 * totalPlays);
        Console.WriteLine(Math.Floor(totalPlays));
    }
}