using System;
class PointInFigure
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool horizontal = x >= 2 && x <= 12 && y >= -3 && y <= 1;
        bool vertical = x >= 4 && x <= 10 && y >= -5 && y <= 3;

        if (horizontal || vertical)
            Console.WriteLine("in");
        else
            Console.WriteLine("out");
    }
}
