// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

public class Solution
{
    public string AddBinary(string a, string b)
    {
        StringBuilder result = new StringBuilder();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry != 0)
        {
            int sum = carry;

            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            carry = sum / 2;
            result.Insert(0, sum % 2);
        }

        return result.ToString();
    }
}