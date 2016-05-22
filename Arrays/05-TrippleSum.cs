using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
            nums[i] = int.Parse(input[i]);
        int sum = 0;
        bool check = true;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
            sum = nums[i] + nums[j];
                if (nums.Contains(sum))
                {
                    Console.WriteLine("{0} + {1} == {2}", nums[i], nums[j], sum);
                    check = false;                      
                }              
            }
        }
        if (check == true)
            Console.WriteLine("No");
    }
}

