using System;
using System.Collections.Generic;
using System.Linq;
class MatrixOfLetters
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        char[,] firstMatrix = new char[r, c];
        char letter = 'A';

        for (int rows = 0; rows < r; rows++)
        {
            for (int cols = 0; cols < c; cols++)
            {
                firstMatrix[rows, cols] = letter;
                letter++;
            }
        }

        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c -1 ; col++)
            {
                Console.Write(firstMatrix[row, col] + " ");
            }
            Console.WriteLine(firstMatrix[row, c - 1]);
        }
    }
}
