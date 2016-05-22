using System;
class DateAfter5Days
{
    static void Main(string[] args)
    {

        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());

        int newDay = day + 5;
        int daysInMonth = 31;
        if (month == 4 || month == 6 || month == 9 || month == 11)
            daysInMonth = 30;
        else if (month == 2)
            daysInMonth = 28;
        if (newDay > daysInMonth)
        {
            newDay = newDay - daysInMonth;
            month++;
        }
        if (month > 12)
            month = 1;
        Console.WriteLine("{0}.{1:00}", newDay, month);
    }
}
