using System;
class RadiansToDegrees
{
    static void Main()
    {
        Console.Write("Enter radians = ");
        double rad = double.Parse(Console.ReadLine());
        double deg = ((180 / Math.PI) * rad);
        Console.WriteLine("Degrees = " + Math.Round(deg, 0));
    }
}