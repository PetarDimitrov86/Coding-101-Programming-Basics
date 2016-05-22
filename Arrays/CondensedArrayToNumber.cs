using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int finalResult = 0;
        int firstLength = originalArray.Length - 1;
        for (int i = 0; i < firstLength; i++)
        {
            int[] modifiedArray = new int[originalArray.Length - 1];
                for (int j = 0; j < modifiedArray.Length; j++)
                    modifiedArray[j] = originalArray[j] + originalArray[j + 1];
                originalArray = modifiedArray;
            finalResult = modifiedArray[0];
        }
        Console.WriteLine(finalResult);
    }
}
