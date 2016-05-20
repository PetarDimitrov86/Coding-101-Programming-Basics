using System;
class CircleAreaPerimeter
{
    static void Main()
    {
        Console.Write("Въведете r = ");
        var r = double.Parse(Console.ReadLine());
        var area = Math.PI * r * r;
        var perimeter = 2 * Math.PI * r;
        Console.WriteLine("Лицето е = " + area);
        Console.WriteLine("Обиколката е = " + perimeter);
    }
}