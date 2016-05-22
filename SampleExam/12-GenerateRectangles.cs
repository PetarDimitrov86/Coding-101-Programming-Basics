using System;
class Increasing4Numbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int minArea = int.Parse(Console.ReadLine());
        if ((n + n) * (n + n) < minArea || n == 0)
        {
            Console.WriteLine("No");
            return;
        }
        int left = 0;
        int top = 0;
        int right = 0;
        int bottom = 0;
        int a = 0;
        int b = 0;
        for (int i = -n; i <= n; i++)
        {
            left = i;
            for (int j = -n; j <= n ; j++)
            {
                top = j;
                for (int k = left+1; k <= n; k++)
                {
                    right = k;
                    for (int l = top+1; l <= n; l++)
                    {
                        bottom = l;
                        a = right - left;
                        b = bottom - top;
                        if (a * b >= minArea)
                        {
                            Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, a * b);
                        }
                    }
                }
            }           
        }
    }
}
