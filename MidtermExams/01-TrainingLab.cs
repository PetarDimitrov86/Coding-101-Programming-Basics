using System;
namespace P1.Training_Lab
{
    class Program
    {
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var widthInCm = width * 100;
            var heightInCm = height * 100;
            var biura = Math.Floor((heightInCm - 100) / 70);
            var rows = Math.Floor(widthInCm / 120);
            var result = (biura * rows) - 3;
            Console.WriteLine(result);
        }
    }
}
