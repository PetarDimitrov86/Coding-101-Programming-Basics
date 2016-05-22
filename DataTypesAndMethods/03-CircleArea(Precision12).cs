using System;
class Program
{
    static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f12}", radius * Math.PI * radius);
    }
}
