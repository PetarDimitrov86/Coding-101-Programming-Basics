using System;
class BonusPoints
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double chetno;
        double five;
        double bonusPoints = 0;
        if (a % 2 == 0)
        {
            chetno = 1;
        }
        else
        {
            chetno = 0;
        }
        if (a % 10 == 5)
        {
            five = 2;
        }
        else
        {
            five = 0;
        }
        if (a <= 100)
        {
            bonusPoints += 5;
        }
        else if (a > 100 && a <=1000)
        {
            bonusPoints = (0.2 * a);
        }
        else if (a > 1000)
        {
            bonusPoints = (0.1 * a);
        }
        Console.WriteLine(bonusPoints + (five + chetno));
        Console.WriteLine((a+bonusPoints) + (five + chetno));
    }
}