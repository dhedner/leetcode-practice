// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>> { new List<int>() };

        foreach (int num in nums)
        {
            int size = result.Count;
            for (int i = 0; i < size; i++)
            {
                List<int> newSubset = new List<int>(result[i]) { num };
                result.Add(newSubset);
            }
        }

        return result;
    }
}