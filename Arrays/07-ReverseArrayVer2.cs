using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int old = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = old;
        }
        foreach (var item in arr)
            Console.Write(item + " ");
            
            //Console.WriteLine(string.Join(" ", arr)); 
    }
}
