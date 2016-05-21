using System;
class LeftAndRightSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 1; i <= n; i++)
        {
            int k = int.Parse(Console.ReadLine());
            sum1 = sum1 + k;
        }
        for (int i = 1; i <= n; i++)
        {
            int j = int.Parse(Console.ReadLine());
            sum2 = sum2 + j;
        }
        if (Math.Abs(sum1 - sum2) == 0)
            Console.WriteLine("Yes, sum = " + sum1);
        else
            Console.WriteLine("No, diff = " + Math.Abs(sum1 - sum2));
    }
}