using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            int rounded;
            if (nums[i] > 0)
                rounded = (int) (nums[i] + 0.5);
            else
                rounded = (int) (nums[i] - 0.5);
            Console.WriteLine($"{nums[i]} => {rounded}");
        }
    }
}
