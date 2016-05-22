using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int divisor = 0;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                divisor += 1;
        }
        if (n <= 2 || divisor >= 1)
            Console.WriteLine("Not Prime");
        else
            Console.WriteLine("Prime");    
	}
}
