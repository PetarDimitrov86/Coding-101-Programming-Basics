using System;
class OddEvenSum
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int sumEven = 0;
        int sumOdd = 0;
        for (int i = 1; i <= num; i++)
        {
            int j = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
                sumEven = sumEven + j;
            else if (i % 2 == 1)
                sumOdd = sumOdd + j;
        }
        if (sumOdd == sumEven)
            Console.WriteLine("Yes Sum = " + sumOdd);
        else
            Console.WriteLine("No Diff = " + (Math.Abs(sumEven - sumOdd)));
    }
}