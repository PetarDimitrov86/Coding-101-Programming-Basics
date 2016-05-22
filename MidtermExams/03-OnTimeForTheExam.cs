using System;
class Program
{
    static void Main(string[] args)
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());

        int MinutesDifference = arrivalHour * 60 - examHour * 60 + arrivalMinute - examMinute;
        int hoursDifference = arrivalHour - examHour;

        if (MinutesDifference > 60)
        {
            hoursDifference = MinutesDifference / 60;
            MinutesDifference = MinutesDifference % 60;
            Console.WriteLine("Late");
            Console.WriteLine("{0}:{1:00} hours after the start", hoursDifference, MinutesDifference);
        }
        else if (MinutesDifference < 60 && MinutesDifference > 0)
        {
            Console.WriteLine("Late");
            Console.WriteLine("{0} minutes after the start", MinutesDifference);
        }
        else if (MinutesDifference % 60 == 0 && MinutesDifference > 0)
        {
            MinutesDifference = 0;
            Console.WriteLine("Late");
            Console.WriteLine("{0}:{1:00} hours after the start", hoursDifference, MinutesDifference);
        }
        else if (examHour == arrivalHour && examMinute == arrivalMinute)
            Console.WriteLine("On Time");
        else if (MinutesDifference >= -30 && MinutesDifference < 0)
        {
            Console.WriteLine("On Time");
            Console.WriteLine("{0} minutes before the start", Math.Abs(MinutesDifference));
        }
        else if (MinutesDifference <= -60)
        {
            hoursDifference = Math.Abs(MinutesDifference / 60);
            MinutesDifference = Math.Abs(MinutesDifference % 60);
            Console.WriteLine("Early");
            Console.WriteLine("{0}:{1:00} hours before the start", hoursDifference, MinutesDifference);
        }
        else if (MinutesDifference > -60 && MinutesDifference < -30)
        {
            Console.WriteLine("Early");
            Console.WriteLine("{0} minutes before the start", Math.Abs(MinutesDifference));
        }
    }
}
