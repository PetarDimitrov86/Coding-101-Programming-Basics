using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        string[] array1 = Console.ReadLine().Split(' ');
        string[] array2 = Console.ReadLine().Split(' ');

        int counterFirstLast = 0;
        int counterLastFirst = 0;

        for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
        {
            if (array1[i] == array2[i])
                counterFirstLast++;
        }

        array1 = array1.Reverse().ToArray();
        array2 = array2.Reverse().ToArray();

        for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
        {
            if (array1[i] == array2[i])
                counterLastFirst++;
        }
        Console.WriteLine(Math.Max(counterLastFirst, counterFirstLast));
    }
}
