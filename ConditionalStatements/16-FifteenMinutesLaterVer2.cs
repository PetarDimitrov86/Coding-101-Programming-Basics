using System;
class FifteenMinuteLater
{
    static void Main(string[] args)
    {
        int chasove = int.Parse(Console.ReadLine());
        int minuti = int.Parse(Console.ReadLine());

        if (minuti <= 44)
        {
            Math.Abs(minuti += 15);
            Console.WriteLine("{0}:{1}", chasove, minuti);
        }
        else if (chasove == 23 && minuti >= 45)
        {
            chasove = chasove - 23;
            minuti += 15;
            minuti -= 60;
            Console.WriteLine("{0}:{1}", chasove, minuti.ToString().PadLeft(2, '0'));
        }

        else if (minuti >= 45)
        {
            chasove += 1;
            minuti += 15;
            minuti -= 60;
            Console.WriteLine("{0}:{1}", chasove, minuti.ToString().PadLeft(2, '0'));
        }
    }
}