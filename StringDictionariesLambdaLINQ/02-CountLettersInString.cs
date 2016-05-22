using System;
using System.Collections.Generic;

class CountLettersInString
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        int counter = 1;
        List<char> charlist = new List<char>(text);
        charlist.Sort();

        for (int i = 0; i < charlist.Count - 1; i++)
        {
            if (charlist[i] == charlist[i+1])
                counter++;
            else
            {
                Console.WriteLine($"{charlist[i]} -> {counter}");
                counter = 1;
            }
        }
        Console.WriteLine($"{charlist[charlist.Count - 1]} -> {counter}");
    }
}