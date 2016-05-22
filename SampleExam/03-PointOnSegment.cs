using System;
class PointOnSegment
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());

        int left = Math.Min(first, second);
        int right = Math.Max(first, second);

        if (point < left || point > right)
        {
            Console.WriteLine("out");
            if (point < first)
                Console.WriteLine(Math.Abs(Math.Abs(left)-Math.Abs(point)));
            else
                Console.WriteLine(Math.Abs(Math.Abs(right) - Math.Abs(point)));
        }
        else if (point >= left && point <= right)
        {
            Console.WriteLine("in");
            if (point - left <= right - point)
                Console.WriteLine(point - left);
            else
                Console.WriteLine(right - point);
        }
    }
}
