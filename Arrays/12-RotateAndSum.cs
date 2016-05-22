using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());
        int[] modiffiedArray = new int[originalArray.Length];
        int[] summedArray = new int[originalArray.Length];
 
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < originalArray.Length; j++)
            {
                if (j == 0)
                    modiffiedArray[0] = originalArray[originalArray.Length - 1];                
                else
                    modiffiedArray[j] = originalArray[j-1];
            }
            for (int m = 0; m < originalArray.Length; m++)
                summedArray[m] = summedArray[m] + modiffiedArray[m];
            for (int l = 0; l < originalArray.Length; l++)                
                originalArray[l] = modiffiedArray[l];
        }
        Console.WriteLine(string.Join(" ", summedArray));
    }
}
