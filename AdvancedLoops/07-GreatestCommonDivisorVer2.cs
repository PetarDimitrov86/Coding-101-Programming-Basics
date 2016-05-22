using System;
class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int divisor = 0;
        for (int i = 1; i <= Math.Max(a, b); i++)
        {
            if (a % i == 0 && b % i == 0)
                divisor = i;
        }
        if (a == 0 || b == 0)
            Console.WriteLine("1");
        else
        Console.WriteLine(divisor);
    }
}
