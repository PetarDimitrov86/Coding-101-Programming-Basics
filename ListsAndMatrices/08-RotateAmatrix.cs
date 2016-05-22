using System;
using System.Collections.Generic;
using System.Linq;
class MatrixOfLetters
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            string[] cells = Console.ReadLine().Split(' ').ToArray();
            for (int col = 0; col < cols; col++)
                matrix[row, col] = cells[col];
        }
        string[,] rotatedMatrix = new string[cols, rows];
        for (int row = 0; row < cols; row++)
        {
            for (int col = 0; col < rows; col++)
                rotatedMatrix[row, col] = matrix[rotatedMatrix.GetLength(1) - col - 1 , row];
                //ili    rotatedMatrix[row, col] = matrix[matrix.GetLength(0) - col - 1 , row];
                //ili    rotatedMatrix[row, col] = matrix[rows - col - 1 , row];
        }
        for (int row = 0; row < cols; row++)
        {
            for (int col = 0; col < rows; col++)
                Console.Write(rotatedMatrix[row, col] + " ");
            Console.WriteLine();
        }
    }
}
