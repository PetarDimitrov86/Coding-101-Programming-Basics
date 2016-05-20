using System;
class TimePlusFifteenMinutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        minutes += 15;

        if (minutes >= 60)
        {
            hours += 1;
            minutes = minutes - 60;
            if (hours > 23)
            {
                hours = 0;
            }
        }
        Console.WriteLine("{0}:{1:00}", hours, minutes);
    }
}