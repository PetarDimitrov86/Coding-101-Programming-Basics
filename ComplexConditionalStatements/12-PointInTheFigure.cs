using System;
class PointInTheFigure
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int x1 = 0;
        int y1 = 0;
        int x2 = 3 * size;
        int y2 = size;
        int x3 = size;
        int y3 = size;
        int x4 = size * 2;
        int y4 = size * 4;

        if ((x > x1 && x < x2 && y > y1 && y < y2) || (x > x3 && x < x4 && y > y3 && y < y4))
            Console.WriteLine("inside");
        else if (y == y3 && x > x3 & x < x4)
            Console.WriteLine("inside");
        else if ((x == x1 || x == x2) && (y >= y1 && y <= y2))
            Console.WriteLine("border");
        else if ((x == x3 || x == x4) && (y >= y3 && y <= y4))
            Console.WriteLine("border");
        else if ((y == y1 || y == y2) && (x >= x1 && x <= x2))
            Console.WriteLine("border");
        else if ((y == y3 || y == y4) && (x >= x3 && x <= x4))
            Console.WriteLine("border");
        else
            Console.WriteLine("outside");
    }
}