using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"{nums[i]} = > ");
            Console.WriteLine(Math.Round(nums[i], MidpointRounding.AwayFromZero));
        }
    }
}
