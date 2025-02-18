// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Solution
{
    public int ClimbStairs(int n)
    {
        int a = 0;
        int b = 1;
        int c = 0;

        int i = 0;

        while (i++ <= n)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}