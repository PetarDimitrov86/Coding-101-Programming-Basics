using System;
class Increasing4Numbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        int n4 = 0;
        if (b - a < 3)
        { 
            Console.WriteLine("No");
            return;
        }
        for (int i = a; i <= b; i++)
        {
            n1 = i;
            for (int j = a; j <= b; j++)
            {
                n2 = j;
                for (int k = a; k <= b; k++)
                {
                    n3 = k;
                    for (int l = a; l <= b; l++)
                    {
                        n4 = l;
                        if (n1 < n2 && n2 < n3 && n3 < n4)
                        {
                            Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3, n4);
                        }
                    }
                }
            }
        }
    }
}
