using System;
class EqualPairs
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sumNewPair = 0;
        int sumOldPair = 0;
        int maxDiff = 1;
        for (int i = 1; i <= n; i++)
        {
            sumOldPair = sumNewPair;
            int f = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            sumNewPair = f + g;
            if (maxDiff < Math.Abs(sumOldPair - sumNewPair) && i >= 2)
                maxDiff = Math.Abs(sumOldPair - sumNewPair);
        }
        if (sumNewPair == sumOldPair || sumOldPair == 0)
            Console.WriteLine("Yes, value={0}", sumNewPair);
        else
            Console.WriteLine("No, maxdiff={0}", maxDiff);
    }
}