// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool IsPalindrome(string s)
{
    string str = s.ToLower();

    int start = 0;
    int end = s.Length - 1;

    while (start <= end)
    {
        while (start < end && !char.IsLetterOrDigit(str[start]))
        {
            start++;
        }
        while (start < end && !char.IsLetterOrDigit(str[end]))
        {
            end--;
        }

        if (str[start] != str[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}

Console.WriteLine(IsPalindrome("racer: Car"));