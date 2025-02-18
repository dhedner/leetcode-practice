// See https://aka.ms/new-console-template for more information

int[] TwoSum_1(int[] nums, int target)
{
    // Values, indexes
    Dictionary<int, int> dict = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        // Calculate the complement of the current number
        int complement = target - nums[i];

        // If the complement is in the dictionary, return the indexes
        if (dict.ContainsKey(complement))
        {
            return new int[] { dict[complement], i };
        }
        // Otherwise, add the number to the dictionary
        dict[nums[i]] = i;
    }

    return new int[] { };
}

int[] TwoSum_2(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return [i, j];
            }
        }
    }

    return [];
}

int[] result = TwoSum_1([2, 3], 4);
Console.WriteLine(result);
