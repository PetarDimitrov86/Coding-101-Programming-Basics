using System;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;
        do
        {
            sum = sum + (n % 10);
            n = n / 10;
        } while (n > 0);
        Console.WriteLine("Sum of digits: {0}", sum);

    }
}
