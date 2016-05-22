using System;
using System.Linq;
class ArrayModifier
{
    static void Main(string[] args)
    {
        long[] originalArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long[] modifiedArray = new long[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
            modifiedArray[i] = originalArray[i];
        string input = Console.ReadLine();
        while (input != "end")
        {
            if (input != "decrease")
            {
                string[] command = input.Split(' ');
                string operation = command[0];
                long index1 = long.Parse(command[1]);
                long index2 = long.Parse(command[2]);
                if (operation == "swap")
                {
                    long oldIndex = index1;
                    modifiedArray[index1] = originalArray[index2];
                    modifiedArray[index2] = originalArray[oldIndex];
                }
                else if (operation == "multiply")
                    modifiedArray[index1] = originalArray[index1] * originalArray[index2];
            }
            else
            {
                for (int i = 0; i < originalArray.Length; i++)
                    modifiedArray[i] -= 1;
            }
            for (int i = 0; i < originalArray.Length; i++)
                originalArray[i] = modifiedArray[i];
            input = Console.ReadLine();
        }
        Console.WriteLine(string.Join(", ", modifiedArray));
    }
}