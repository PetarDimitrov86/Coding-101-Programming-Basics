using System;
class Program
{
    static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(' ');
        string[] newArr = new string[3];
        if (arr.Length == 1)
        {
            newArr = new string[1];
            newArr[0] = arr[0];
        }
        else if (arr.Length % 2 == 0)
        {
            newArr = new string[2];
            newArr[0] = arr[arr.Length / 2 - 1];
            newArr[1] = arr[arr.Length / 2];
        }
        else if (arr.Length % 2 == 1)
        {
            newArr = new string[3];
            newArr[0] = arr[arr.Length / 2 - 1];
            newArr[1] = arr[arr.Length / 2];
            newArr[2] = arr[arr.Length / 2 + 1];
        }
        Console.Write("{ ");
        Console.Write(string.Join(", ", newArr));
        Console.WriteLine(" }");
    }
}
