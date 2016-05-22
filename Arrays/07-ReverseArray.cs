using System;
class Program
{
    static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(' ');
        string[] modifiedArr = new string[arr.Length];

        for (int i = 0; i < arr.Length / 2; i++)
            modifiedArr[i] = arr[arr.Length - i - 1];

        for (int i = 0; i < arr.Length / 2 + 1; i++)
            modifiedArr[modifiedArr.Length - i - 1] = arr[i];

        foreach (var item in modifiedArr)
            Console.Write(item + " ");
    }
}
