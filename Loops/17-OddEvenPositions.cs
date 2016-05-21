using System;
class OddEvenPositions
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        double oddSum = 0;
        double oddMax = double.MinValue;
        double oddMin = double.MaxValue;
        double evenSum = 0;
        double evenMax = double.MinValue;
        double evenMin = double.MaxValue;
        for (int i = 1; i <= num; i++)
        {
            double f = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum = evenSum + f;
                if (evenMax < f)
                    evenMax = f;
                if (evenMin > f)
                    evenMin = f;
            }
            if (i % 2 == 1)
            {
                oddSum = oddSum + f;
                if (oddMax < f)
                    oddMax = f;
                if (oddMin > f)
                    oddMin = f;
            }
        }
        if (num == 1)
        {
            Console.WriteLine("oddsum " + oddSum);
            Console.WriteLine("oddmin " + oddMin);
            Console.WriteLine("oddmax " + oddMax);
            Console.WriteLine("evensum " + evenSum);
            Console.WriteLine("evenmin No");
            Console.WriteLine("evenmax No");
        }
        else if (num == 0)
        {
            Console.WriteLine("oddsum " + oddSum);
            Console.WriteLine("oddmin No");
            Console.WriteLine("oddmax No");
            Console.WriteLine("evensum " + evenSum);
            Console.WriteLine("evenmin No");
            Console.WriteLine("evenmax No");
        }
        else
        {
            Console.WriteLine("oddsum " + oddSum);
            Console.WriteLine("oddmin " + oddMin);
            Console.WriteLine("oddmax " + oddMax);
            Console.WriteLine("evensum " + evenSum);
            Console.WriteLine("evenmin " + evenMin);
            Console.WriteLine("evenmax " + evenMax);
        }
    }
}