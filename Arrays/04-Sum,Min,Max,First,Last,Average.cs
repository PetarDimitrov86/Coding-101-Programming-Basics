using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] sequence = new int[n];

        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
            if (sequence[i] > max)
                max = sequence[i];
            if (sequence[i] < min)
                min = sequence[i];
            sum += sequence[i];
        }
        average = (double)sum / n;
        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
        Console.WriteLine("First = {0}", sequence[0]);
        Console.WriteLine("Last = {0}",sequence[sequence.Length-1]);
        Console.WriteLine("Average = {0}", average);
    }
}
