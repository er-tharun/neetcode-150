namespace valid_palindrome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
    }

    public static bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;

        var arr = s.ToCharArray();
        while(l<r)
        {
            while(l<r &&!IsAlphaNumeric(arr[l]))
                l++;
            while(l < r &&!IsAlphaNumeric(arr[r]))
                r--;
            if(arr[l].ToString().ToLower() == arr[r].ToString().ToLower())
            {
                l++;
                r--;
            }
            else
                return false;
        }
        return true;
    }

    private static bool IsAlphaNumeric(char ch) => Char.IsLetterOrDigit(ch);
}
