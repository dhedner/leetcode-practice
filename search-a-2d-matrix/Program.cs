// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == target)
                {
                    return true;
                }
            }
        }
        return false;
    }

    // Assume rows are ascending from left to right and columns are ascending from top to bottom
    public bool SearchMatrix2(int[][] matrix, int target)
    {
        int column = matrix[0].Length - 1;
        int row = 0;

        while (column >= 0 && row < matrix.Length)
        {
            if (matrix[row][column] == target)
            {
                return true;
            }
            else if (matrix[row][column] > target)
            {
                column--;
            }
            else if (matrix[row][column] < target)
            {
                row++;
            }
        }
        return false; 
    }
}