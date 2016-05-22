using System;
class IncreasingElements
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int previusNum = int.MinValue;
        int maxCounter = 0;
        for (int i = 1; i <= n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > previusNum)
                counter++;
            else
                counter = 1;
            if (counter > maxCounter)
                maxCounter = counter;
            previusNum = a;
        }
        Console.WriteLine(maxCounter);
    }
}
