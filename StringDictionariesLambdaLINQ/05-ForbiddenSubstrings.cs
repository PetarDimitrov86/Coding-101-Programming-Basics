using System;
using System.Collections.Generic;
using System.Linq;
class ForbiddenSubstrings
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string[] forbiddenWord = Console.ReadLine().Split(' ').ToArray();

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < forbiddenWord.Length; j++)
            {
                if (forbiddenWord[j].Length + i > text.Length)
                    continue;
                if (text.Substring(i, forbiddenWord[j].Length) == forbiddenWord[j])
                    text = text.Replace(forbiddenWord[j], new string('*', forbiddenWord[j].Length));
            }
        }
        Console.WriteLine(text);
    }
}