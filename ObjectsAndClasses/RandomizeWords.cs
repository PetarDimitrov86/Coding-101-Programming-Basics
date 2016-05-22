using System;
using System.Collections.Generic;
using System.Linq;
class RandomizeWords
{
    static void Main(string[] args)
    {
        List<string> words = Console.ReadLine().Split(' ').ToList();
        List<string> randomWords = new List<string>();
        Random randomizer = new Random();
        while (words.Count> 0)
        {
            int position = randomizer.Next(0, words.Count);
            randomWords.Add(words[position]);
            words.RemoveAt(position);
        }
        Console.WriteLine(string.Join("\n", randomWords));
    }
}