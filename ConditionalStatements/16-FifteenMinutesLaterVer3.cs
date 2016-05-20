using System;
class FifteenMinuteLater
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int result = hours * 60 + minutes + 15;
        int newhours = result / 60;
        if (newhours >= 24)
        {
            newhours -= 24;
        }
        int newminutes = result % 60;
        Console.WriteLine("{0}:{1}", newhours, newminutes.ToString().PadLeft(2, '0'));

        //Version2 Format h:mm
        //Console.WriteLine("{0}:{1:00}",newhours, newminutes);
    }
}