// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int SearchInsert(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if ((nums[i] == target) || (nums[i] > target))
        {
            return i;
        }
    }

    if (target < nums[0])
    {
        return 0;
    }

    return nums.Length + 1;
}

int[] nums = { 1, 3, 5, 6 };
int target = 7;
Console.WriteLine(SearchInsert(nums, target));