// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public void Backtrack(int[] nums, List<int> path, IList<IList<int>> result)
    {
        if (path.Count == nums.Length)
        {
            result.Add(new List<int>(path));
            return;
        }

        foreach (int num in nums)
        {
            if (path.Contains(num))
            {
                continue;
            }

            path.Add(num);
            Backtrack(nums, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }

    public void BacktrackUnique(int[] nums, List<int> path, HashSet<int> visited, IList<IList<int>> result)
    {
        if (path.Count == nums.Length)
        {
            result.Add(new List<int>(path));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (visited.Contains(i) || (num == nums[i - 1] && !visited.Contains(i - 1)))
            {
                continue;
            }

            visited.Add(i);
            path.Add(num);
            BacktrackUnique(nums, path, visited, result);
            visited.Remove(i);
            path.RemoveAt(path.Count - 1);
        }
    }

    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Backtrack(nums, new List<int>(), result);
        return result;
    }

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        HashSet<int> visited = new HashSet<int>();
        BacktrackUnique(nums, new List<int>(), visited, result);
        return result;
    }
}