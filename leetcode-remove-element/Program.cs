// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int RemoveElement(int[] nums, int val)
{
    int k = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        // If the current number is not equal to the value, add it to the array
        if (nums[i] != val)
        {
            // Move the number to the beginning of the array
            nums[k++] = nums[i];
        }
    }

    return k;
}