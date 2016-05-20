using System;
using System.Collections.Generic;
class NumbersInWords
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        if ((x > 100) || (x < 0))
        {
            Console.WriteLine("invalid number");
            return;
        }

        string[] toNineteen = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        string[] toNinety = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };

        if (x < 20)
        {
            Console.WriteLine(toNineteen[x]);
        }
        else
        {
            int nineteenRemainder = x % 10;
            Console.WriteLine(toNinety[x / 10 - 2] + (nineteenRemainder > 0 ? " " + toNineteen[x % 10] : ""));
        }
    }
}