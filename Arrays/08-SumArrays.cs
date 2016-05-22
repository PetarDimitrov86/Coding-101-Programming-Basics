using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] pile1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] pile2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] equalPile = new int[Math.Max(pile1.Length, pile2.Length)];
        if (pile1.Length > pile2.Length)
        {
            for (int i = 0; i < pile1.Length; i++)
                equalPile[i] = pile2[i % pile2.Length];
        }
        else if (pile1.Length <= pile2.Length)
        {
            for (int i = 0; i < pile2.Length; i++)
                equalPile[i] = pile1[i % pile1.Length];
        }
        int[] summedArray = new int[equalPile.Length];
        for (int i = 0; i < summedArray.Length; i++)
        {
            if (pile1.Length > pile2.Length)
                summedArray[i] = pile1[i] + equalPile[i];
            else if (pile1.Length <= pile2.Length)
                summedArray[i] = pile2[i] + equalPile[i];
        }
        Console.WriteLine(string.Join(" ", summedArray));
    }
}
