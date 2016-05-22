using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i = 2*i+1)
        {
            Console.WriteLine(i);
        }
    }
}
