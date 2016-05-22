using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        
        for (int digit1  = 1; digit1 <= n; digit1++)
        {
            for (int digit2 = 1; digit2 <= n; digit2++)
            {            
                for (char first = 'a'; first < 'a' + (char)l; first++)
                {
                    for (char second = 'a'; second < 'a'+ (char)l; second++)
                    {
                        for (int lastDigit = 1; lastDigit <= n; lastDigit++)
                        {
                            if (lastDigit > digit1 && lastDigit > digit2)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", digit1, digit2, first, second, lastDigit);
                            }
                        }
                    }
                }
            }
        }
    }
}
