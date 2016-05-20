using System;
using System.Collections.Generic;
class NumbersInWords
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        var smallNumbers = new Dictionary<int, string>
        {
            {0, "" }, { 1, "one" }, { 2, "two" }, { 3, "three" }, {4, "four" }, {5, "five" },
            {6, "six" }, {7, "seven" }, {8, "eight" }, {9, "nine" }, {10, "ten" }, {11, "eleven" }, {12, "twelve" },
            { 13, "thirteen" }, {14, "fourteen" }, {15, "fifteen" }, {16, "sixteen" }, {17, "seventeen" }, {18, "eighteen" }, {19, "nineteen" }
        };
        var bigNumbers = new Dictionary<int, string>
        {
            { 20, "twenty" }, {30, "thirty" }, {40, "fourty" }, {50, "fifty" }, {60, "sixty" },
            {70, "seventy" }, {80, "eighty" }, {90, "ninety" }
        };
        if (num < 0 || num > 100)
        {
            Console.WriteLine("invalid number");
        }
        else if (num < 20 && num > 0)
        {
            Console.WriteLine(smallNumbers[num]);
        }
        else if (num == 100)
        {
            Console.WriteLine("one hundred");
        }
        else if (num >= 20 && num % 10 == 0)
        {
            Console.WriteLine(bigNumbers[(num / 10) * 10]);
        }
        else if (num >= 20)
        {
            Console.WriteLine(bigNumbers[(num / 10) * 10] + " " + smallNumbers[num % 10]);
        }
        else if (num == 0)
        {
            Console.WriteLine("zero");
        }
    }
}