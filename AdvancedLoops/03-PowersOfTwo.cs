using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int power = 1;
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(power);
            power *= 2;
        }
    }
}
