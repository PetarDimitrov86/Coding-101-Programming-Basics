using System;
class SumSeconds
{
    static void Main()
    {
        var firstTime = int.Parse(Console.ReadLine());
        var secondTime = int.Parse(Console.ReadLine());
        var thirdTime = int.Parse(Console.ReadLine());

        var secondsSum = firstTime + secondTime + thirdTime;
        var minutes = secondsSum / 60;
        var seconds = secondsSum % 60;

        Console.WriteLine("{0}:{1:00}", minutes, seconds);
    }
}