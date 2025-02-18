// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool IsPalindrome(int x)
{
    // If the number is negative or ends with a zero, it is not a palindrome
    if (x < 0 || (x % 10 == 0 && x != 0))
    {
        return false;
    }

    // Reverse half of the number
    int reversed = 0;
    while (x > reversed)
    {
        reversed = reversed * 10 + x % 10;
        x /= 10;
    }

    // Check if the number is a palindrome (if the length is odd, remove the middle digit)
    return x == reversed || x == reversed / 10;
}