﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            int start = 0;
            int end = n - 1;

            while (start < end)
            {
                int temp = matrix[i][start];
                matrix[i][start] = matrix[i][end];
                matrix[i][end] = temp;

                start++;
                end--;
            }
        }
    }
}