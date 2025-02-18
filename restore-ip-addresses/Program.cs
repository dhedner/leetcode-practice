// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution
{
    public bool IsValid(string segment)
    {
        if (segment.Length > 3)
        {
            return false;
        }

        int number = int.Parse(segment);

        if (number < 0 || number > 255 || segment.Length != number.ToString().Length)
        {
            return false;
        }

        return true;
    }

    public void Permutations(string s, int index, IList<string> list, IList<string> result)
    {
        if (index == s.Length && list.Count == 4)
        {
            string address = string.Join(".", list.ToArray());
            result.Add(address);
            return;
        }

        for (int i = 1; i <= s.Length - index; i++)
        {
            string segment = s.Substring(index, i);
            
            if (IsValid(segment))
            {
                list.Add(segment);
                Permutations(s, i + index, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }

    public IList<string> RestoreIpAddresses(string s)
    {
        IList<string> result = new List<string>();

        if (string.IsNullOrEmpty(s) || s.Length > 12)
        {
            return result;
        }

        Permutations(s, 0, new List<string>(), result);
        return result;
    }
}