using System;
class BonusPoints
{
    public static void Main(string[] args)
    {
        var num = float.Parse(Console.ReadLine());
        float bonus = 5;
        if (num > 1000)
            bonus = num / 10;
        else if (num > 100)
            bonus = num / 5;
        if (num % 2 == 0)
            bonus = bonus + 1;
        else if ((num % 5 == 0) && (!(num % 2 == 0)))
            bonus = bonus + 2;
        Console.WriteLine(bonus);
        Console.WriteLine((bonus + num));
    }
}