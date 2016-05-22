using System;
using System.Linq;
class MultiplyTargetedCell
{
    static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int rows = dimensions[0];
        int cols = dimensions[1];
        int[,] originalMatrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] cells = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
                originalMatrix[row, col] = cells[col];
        }
        int[] target = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rowTarget = target[0];
        int colTarget = target[1];
        int sumNewValue = 0;
        int initialValue = originalMatrix[rowTarget, colTarget];

        for (int row = rowTarget - 1; row <= rowTarget + 1; row++)
        {
            for (int col = colTarget - 1; col <= colTarget + 1; col++)
            {
                if (col == colTarget && row == rowTarget)
                    continue;
                else
                    sumNewValue += originalMatrix[row, col];
            }
        }
        originalMatrix[rowTarget, colTarget] *= sumNewValue;

        for (int row = rowTarget - 1; row <= rowTarget + 1; row++)
        {
            for (int col = colTarget - 1; col <= colTarget + 1; col++)
            {
                if (col == colTarget && row == rowTarget)
                    continue;
                else
                    originalMatrix[row, col] *= initialValue;
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
                Console.Write(originalMatrix[row, col] + " ");
            Console.WriteLine();
        }

    }
}