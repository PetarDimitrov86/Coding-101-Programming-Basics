using System;
class Bricks
{
    static void Main(string[] args)
    {
        int bricks = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int cartCapacity = int.Parse(Console.ReadLine());

        int brickersPerCourse = workers * cartCapacity;
        double trip = (double) bricks / brickersPerCourse;
        Console.WriteLine(Math.Ceiling(trip));
    }
}
