using System;
using System.Collections.Generic;
using System.Linq;
class OddOccurences
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();
        Dictionary<string, int> seperateWords = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (seperateWords.ContainsKey(word))
                seperateWords[word]++;
            else
                seperateWords[word] = 1;
        }
        List<string> finalResult = new List<string>();
        foreach (var result in seperateWords)
        {
            if (result.Value % 2 == 1)
                finalResult.Add(result.Key);
        }
        Console.WriteLine(string.Join(", ", finalResult));
    }
}