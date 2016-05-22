using System;
using System.Collections.Generic;
using System.Linq;
class OccurencesInString
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string word = Console.ReadLine().ToLower();
        int occurences = 0;
        int position = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text.IndexOf(word, position) == i)
            {
                occurences++;
                position = i + 1;
            }
        }
        Console.WriteLine(occurences);
    }
}