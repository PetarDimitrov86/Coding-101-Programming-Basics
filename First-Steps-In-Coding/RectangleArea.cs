using System;
class RectangleArea
{
    static void Main()
    {
        Console.Write("a = ");
        var a = int.Parse(Console.ReadLine());              //изписването на допълнителен текст като а= понякога в джъдж може да не се приеме правилно
        Console.Write("b = ");
        var b = int.Parse(Console.ReadLine());
        Console.WriteLine(a * b);
    }
}