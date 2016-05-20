using System;
class FifteenMinutesLater
{
    static void Main()
    {
        var hours1 = int.Parse(Console.ReadLine());
        var minutes1 = int.Parse(Console.ReadLine());
        var minutes2 = minutes1 + 15;
        var hours2 = hours1;

        if (minutes2 >= 60)
        {
            minutes2 = minutes2 - 60;
            hours2 = hours2 + 1;
            if (hours2 >= 24)
            {
                if (minutes2 < 10)
                {
                    Console.WriteLine("0:0{0}", minutes2);
                }
                else
                {
                    Console.WriteLine("0:{0}", minutes2);
                }
            }
            else
            {
                if (minutes2 < 10)
                {
                    Console.WriteLine("{0}:0{1}", hours2, minutes2);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", hours2, minutes2);
                }
            }
        }
        else if (minutes2 < 60)
        {
            if (minutes2 < 10)
            {
                Console.WriteLine("{0}:0{1}", hours2, minutes2);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours2, minutes2);
            }
        }
    }
}