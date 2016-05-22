using System;
class PrintStringLetters
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];
            Console.WriteLine("str[{0}] -> '{1}'", i, letter);
        }
    }
}