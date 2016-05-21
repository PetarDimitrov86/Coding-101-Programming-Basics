using System;
class SumNumbers
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int j = 0;
        for (int i = 1; i <= num; i++)
        {
            int k = int.Parse(Console.ReadLine());
            j = k + j;
        }
        Console.WriteLine(j);
    }
}