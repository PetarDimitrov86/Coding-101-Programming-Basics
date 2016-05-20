using System;
class TwoDRectangleArea
{
    static void Main()
    {
        Console.Write("Въведете х1 = ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Въведете y1 = ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Въведете x2 = ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Въведете y2 = ");
        double y2 = double.Parse(Console.ReadLine());
        double area = Math.Abs((x1 - x2) * (y1 - y2));          //Math.Abs - абсолютна стойност, модул на числото, прави - винаги да е +
        double perimeter = ((Math.Abs(x1 - x2) * 2) + (Math.Abs(y1 - y2) * 2));           //Math.Abs се слага за да се сметнат положителните числа за всичките страни, 
        //при площта няма значение, тъй като двете просто се умножават и тогава се превръща стойността от минус към плюс
        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}