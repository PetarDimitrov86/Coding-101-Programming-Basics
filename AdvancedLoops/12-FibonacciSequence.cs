using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int f1 = 1;
        int f2 = 1;
        int f3 = 1;
        for (int i = 0; i < n; i++)
        {
            f3 = f2;
            f2 = f2 + f1;
            f1 = f3;
        }
        Console.WriteLine(f3);
    }
}
