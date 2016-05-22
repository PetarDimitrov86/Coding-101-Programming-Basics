using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sumDigits = 0;
        for (int i = 1; i <= n; i++)
        {
            int digits = i;
            while (digits > 0)
            {         
                sumDigits += digits % 10;
                digits = digits / 10;
            }
            if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                Console.WriteLine("{0} -> True", i);
            else
                Console.WriteLine("{0} -> False", i);
            sumDigits = 0;
        }  
    }
}
