// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public void SortColors(int[] nums)
    {
        int redCount = 0;
        int whiteCount = 0;
        int blueCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                redCount++;
            }
            else if (nums[i] == 1)
            {
                whiteCount++;
            }
            else
            {
                blueCount++;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (redCount > 0)
            {
                nums[i] = 0;
                redCount--;
            }
            else if (whiteCount > 0)
            {
                nums[i] = 1;
                whiteCount--;
            }
            else
            {
                nums[i] = 2;
                blueCount--;
            }
        }
    }
}