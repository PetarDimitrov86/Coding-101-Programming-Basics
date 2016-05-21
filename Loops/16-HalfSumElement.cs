using System;
class HalfSumElement
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int bigNum = int.MinValue;
        int sumNum = 0;
        for (int i = 0; i < n; i++)
        {
            int j = int.Parse(Console.ReadLine());
            sumNum = sumNum + j;
            if (bigNum < j)
                bigNum = j;
        }
        sumNum = sumNum - bigNum;
        if (bigNum == sumNum)
            Console.WriteLine("Yes Sum = " + bigNum);
        else
            Console.WriteLine("No Diff = " + Math.Abs(sumNum - bigNum));
    }
}