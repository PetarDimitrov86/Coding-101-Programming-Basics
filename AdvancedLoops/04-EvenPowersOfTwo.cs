using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int power = 1;
        for (int i = 1; i <= n+1; i+=2)
        {
            Console.WriteLine(power);
            power *= 4;
        }
    }
}
