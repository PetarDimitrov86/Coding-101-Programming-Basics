using System;
using System.Collections.Generic;
class NumbersInWords
{
    public static void Main(string[] args)
    {
        var under13 = new Dictionary<int, string> {
                { 0,"zero" },{ 1,"one" },{ 2,"two" },{ 3,"three" },
                { 4,"four" },{ 5,"five" },{ 6,"six" },{ 7,"seven" },
                { 8,"eight" },{ 9,"nine" },{ 10,"ten" },    { 11,"eleven" },
                { 12,"twelve" }
            };
        var under10 = new Dictionary<int, string> {
                { 0,"" },{ 1," one" },{ 2," two" },{ 3," three" },
                { 4," four" },{ 5," five" },{ 6," six" },{ 7," seven" },
                { 8," eight" },{ 9," nine" }
            };
        var above13 = new Dictionary<int, string> {
                { 2,"twen" },{ 3,"thir" },{ 4,"four" },
                { 5,"fif" },{ 6,"six" },{ 7,"seven" },
                { 8,"eigh" },{ 9,"nine" }
            };
        var a = int.Parse(Console.ReadLine());
        if ((a > (-1)) && (a < 101))
        {
            if (a < 13)
                Console.WriteLine(under13[a]);
            else if (a < 20)
                Console.WriteLine(above13[(a % 10)] + "teen");
            else if (a < 100)
                Console.WriteLine(above13[(a / 10)] + "ty" + under10[(a % 10)]);
            else if (a == 100)
                Console.WriteLine("one hundred");
        }
        else
            Console.WriteLine("invalid number");
    }
}