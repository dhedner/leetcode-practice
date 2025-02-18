// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");

public class Solution
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        int rows = maze.Length;
        int cols = maze[0].Length;

        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();

        queue.Enqueue((entrance[0], entrance[1], 0));

        while (queue.Count > 0)
        {
            var (row, col, steps) = queue.Dequeue();

            if (row != entrance[0] || col != entrance[1])
            {
                if (row == 0 || row == rows - 1 || col == 0 || col == cols - 1)
                {
                    return steps;
                }
            }

            if (maze[row][col] == '+')
            {
                continue;
            }

            maze[row][col] = '+';

            if (row - 1 >= 0 && maze[row - 1][col] == '.')
            {
                queue.Enqueue((row - 1, col, steps + 1));
            }

            if (row + 1 < rows && maze[row + 1][col] == '.')
            {
                queue.Enqueue((row + 1, col, steps + 1));
            }

            if (col - 1 >= 0 && maze[row][col - 1] == '.')
            {
                queue.Enqueue((row, col - 1, steps + 1));
            }

            if (col + 1 < cols && maze[row][col + 1] == '.')
            {
                queue.Enqueue((row, col + 1, steps + 1));
            }
        }

        return -1;
    }
}