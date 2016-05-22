using System;
class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());

        long[] first = new long[n];
        first[0] = 1;
        for (int i = 1; i < n; i++)
        {
            long sum = 0;
            for (long j = i - k; j <= i - 1; j++)
            {
            if (j >= 0)
                sum += first[j];
            }         
            first[i] = sum;
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine(first[i]);
    }
}
