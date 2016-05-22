using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int remainder = n % 10;
        int wholePart = n;
        int sumDigits = 0;
        while (wholePart != 0)
        {
            sumDigits += remainder;
            wholePart = wholePart / 10;
            remainder = wholePart % 10;
        }
        Console.WriteLine(sumDigits);
    }
}
