using System;
using System.Collections.Generic;
using System.Linq;
class SplitByWordCasing
{
    static void Main(string[] args)
    {
        List<string> originalList = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> MixedCase = new List<string>();
        int lowerCount = 0;
        int upperCount = 0;

        for (int i = 0; i < originalList.Count; i++)
        {
            string result = originalList[i];
            for (int j = 0; j < result.Length; j++)
            {
                if (char.IsLower(result[j]))
                    lowerCount++;
                else if (char.IsUpper(result[j]))
                    upperCount++;
            }
            if (lowerCount == result.Length)
                lowerCase.Add(originalList[i]);
            else if (upperCount == result.Length)
                upperCase.Add(originalList[i]);
            else
                MixedCase.Add(originalList[i]);
            lowerCount = 0;
            upperCount = 0;
        }
        Console.Write("Lower-Case: ");
        Console.WriteLine(string.Join(", ", lowerCase));
        Console.Write("Mixed-Case: ");
        Console.WriteLine(string.Join(", ", MixedCase));
        Console.Write("Upper-Case: ");
        Console.WriteLine(string.Join(", ", upperCase));
    }
}