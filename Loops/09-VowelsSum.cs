using System;
class VowelsSum
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int sumWords = 0;
        for (int i = 0; i < word.Length; i++)
        //задължително от 0 до < броя на символите, защото 0 от масив се счита за първа позиция
        //може да е до <= s.Length - 1, но задължително трябва да започва от 0, за да се вземат всички стойности на масива
        {
            if (word[i] == 'a')
                sumWords = sumWords + 1;
            if (word[i] == 'e')
                sumWords = sumWords + 2;
            if (word[i] == 'i')
                sumWords = sumWords + 3;
            if (word[i] == 'o')
                sumWords = sumWords + 4;
            if (word[i] == 'u')
                sumWords = sumWords + 5;
        }
        Console.WriteLine(sumWords);
    }
}