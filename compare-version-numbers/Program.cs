// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        IList<int> firstVersion = version1.Split('.').Select(int.Parse).ToList();
        IList<int> secondVersion = version2.Split('.').Select(int.Parse).ToList();

        while (firstVersion.Count != secondVersion.Count)
        {
            if (firstVersion.Count > secondVersion.Count)
            {
                secondVersion.Add(0);
            }
            else
            {
                firstVersion.Add(0);
            }
        }

        for (int i = 0; i < firstVersion.Count; i++)
        {
            if (firstVersion[i] > secondVersion[i])
            {
                return 1;
            }
            else if (firstVersion[i] < secondVersion[i])
            {
                return -1;
            }
        }

        return 0;
    }
}