using System;
using System.Collections.Generic;
using System.Linq;
class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);
        string[,] originalMatrix = new string[rows, cols];

        char letter = 'a';
        char middleLetter = 'a';

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                originalMatrix[row, col] = $"{letter}{middleLetter}{letter}";
                middleLetter++;
            }
            letter++;
            middleLetter = letter;
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
                Console.Write(originalMatrix[row, col] + " ");
            Console.WriteLine();
        }
    }
}
