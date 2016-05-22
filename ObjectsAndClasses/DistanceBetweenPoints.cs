using System;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}


class DistanceBetweenPoints
{
    static void Main(string[] args)
    {
        int[] firstPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Point first = new Point() { X = firstPoint[0], Y = firstPoint[1] };
        Point second = new Point() { X = secondPoint[0], Y = secondPoint[1] };

        double distanceX = Math.Abs(first.X - second.X);
        double distanceY = Math.Abs(first.Y - second.Y);
        double distancePoints = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);
        Console.WriteLine($"{distancePoints:f3}");
    }
}