using System;
class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;

        if (sum / 2 == a)
           Console.WriteLine("{0} + {1} = {2}", Math.Min(b, c), Math.Max(b, c), a);
        else if (sum / 2 == b)
            Console.WriteLine("{0} + {1} = {2}", Math.Min(a, c), Math.Max(a, c), b);
        else if (sum / 2 == c)
            Console.WriteLine("{0} + {1} = {2}", Math.Min(b, a), Math.Max(b, a), c);
        else
            Console.WriteLine("No");
    }
}
