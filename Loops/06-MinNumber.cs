using System;
class MinNumber
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int minNumber = int.MaxValue;
        for (int i = 1; i <= num; i++)
        {
            int k = int.Parse(Console.ReadLine());
            if (k < minNumber)
                minNumber = k;
        }
        Console.WriteLine(minNumber);
    }
}