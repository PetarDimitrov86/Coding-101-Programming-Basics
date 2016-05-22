using System;
class Strawberry
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
            Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', 2 * i), new string('-', n - 2 * i));
        for (int i = 0; i < (n + 1) / 2; i++)
            Console.WriteLine("{0}#{1}#{0}", new string('-', n - 2 * i), new string('.', 4 * i + 1));
        for (int i = 0; i < n + 1; i++)
            Console.WriteLine("{0}#{1}#{0}", new string('-', i), new string('.', 2 * n + 1 - 2 * i));
    }
}