// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public bool CanJump(int[] nums)
    {
        int reach = 0;
        int index = 0;

        while (index < nums.Length)
        {
            if (index > reach)
            {
                return false;
            }

            reach = Math.Max(reach, nums[index] + index);

            if (reach >= nums.Length - 1)
            {
                return true;
            }

            index++;
        }

        return false;
    }

    public int Jump(int[] nums)
    {
        int jumps = 0;
        int reach = 0;
        int end = 0;

        int index = 0;
        while (index < nums.Length - 1)
        {
            reach = Math.Max(reach, nums[index] + index);

            if (index == end)
            {
                jumps++;
                end = reach;
            }

            index++;
        }

        return jumps;
    }
}