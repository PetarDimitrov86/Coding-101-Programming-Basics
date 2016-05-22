using System;
using System.Numerics;

class BigFactorial
{
    static void Main(string[] args)
    {
        BigInteger num = BigInteger.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}