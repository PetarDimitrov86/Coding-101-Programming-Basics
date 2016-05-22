using System;
using System.Collections.Generic;
using System.Linq;
class TwoByTwoSquareMatrix
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);
        int counter = 0;
        string[,] originalMatrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] cells = Console.ReadLine().Split(' ').ToArray();
            for (int col = 0; col < cols; col++)
            {
                originalMatrix[row, col] = cells[col];
            }
        }
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                if (originalMatrix[row, col] == originalMatrix[row + 1, col] && originalMatrix[row + 1, col] == originalMatrix[row + 1, col + 1]
                    && originalMatrix[row, col] == originalMatrix[row, col + 1])
                    counter++;
            }
        }
        Console.WriteLine(counter);
    }
}