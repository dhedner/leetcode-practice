// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int RemoveDuplicates(int[] nums)
{
    int k = 1;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[k++] = nums[i];
        }
    }

    return k;
}

int[] nums = { 1, 1, 2 };
int result = RemoveDuplicates(nums);
Console.WriteLine(result);