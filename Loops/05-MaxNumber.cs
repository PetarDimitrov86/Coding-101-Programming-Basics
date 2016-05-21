using System;
class MaxNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int maxNumber = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            int k = int.Parse(Console.ReadLine());
            if (k >= maxNumber)
                maxNumber = k;
        }
        Console.WriteLine(maxNumber);
    }
}