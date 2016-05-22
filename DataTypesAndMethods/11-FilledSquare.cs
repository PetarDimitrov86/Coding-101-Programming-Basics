using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        UpperLowerPart(n);
        MiddlePart(n);
        UpperLowerPart(n);
    }
    static void UpperLowerPart (int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
    static void MiddlePart (int n)
    {
        for (int row = 0; row < n-2; row++)
        {
            Console.Write('-');
            for (int col = 0; col < n-1; col++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
