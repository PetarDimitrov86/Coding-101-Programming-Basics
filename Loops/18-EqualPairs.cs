using System;
class EqualPairs
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sumNewPair = 0;
        int sumOldPair = 0;
        int maxDiff = 1;
        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            int f = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            sumNewPair = f + g;
            if (sumNewPair == sumOldPair)
            {
                counter += 1;
            }
            if (maxDiff < Math.Abs(sumOldPair - sumNewPair) && i >= 2)
                maxDiff = Math.Abs(sumOldPair - sumNewPair);
            if (sumNewPair != sumOldPair)
            {
                sumOldPair = sumNewPair;
            }
        }
        if (counter == n - 1)
            Console.WriteLine("Yes, value={0}", sumNewPair);
        else
            Console.WriteLine("No, maxdiff={0}", maxDiff);
    }
}