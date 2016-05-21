using System;
using System.Linq;
class HalfSumElementVer2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }
        int sum1 = sum - arr.Max();
        if (sum1 == arr.Max())
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", sum1);
        }
        else if (sum1 < arr.Max())
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", arr.Max() - sum1);
        }
        else if (sum1 > arr.Max())
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", sum1 - arr.Max());
        }
    }
}