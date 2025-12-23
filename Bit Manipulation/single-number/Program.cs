namespace single_number;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/single-number/
        Console.WriteLine(SingleNumber(new int[] {4,1,2,1,2}));
    }

    public static int SingleNumber(int[] nums) {
        int result = 0;

        foreach(var num in nums)
        {
            result ^= num;
        }

        return result;
    }
}
