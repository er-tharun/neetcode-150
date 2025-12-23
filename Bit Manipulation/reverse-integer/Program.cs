namespace reverse_integer;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/reverse-integer/
        Console.WriteLine(Reverse(98652));
    }

    public static int Reverse(int x) {
        int MIN = int.MinValue;
        int MAX = int.MaxValue;
        int res = 0;

        while(x != 0)
        {
            int digit =  x%10;
            x /= 10;

            if(res > MAX/10 || (res == MAX/10 && digit > MAX/10))
                return 0;
            if(res < MIN/10 || (res == MIN/10 && digit < MIN/10))
                return 0;

            res = (res * 10) + digit;
        }

        return res;
    }
}
