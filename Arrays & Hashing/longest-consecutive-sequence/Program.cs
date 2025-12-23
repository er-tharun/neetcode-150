namespace longest_consecutive_sequence;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/longest-consecutive-sequence
        Console.WriteLine(LongestConsecutive(new int[] {100,4,200,1,3,2}));
    }

    public static int LongestConsecutive(int[] nums) {
        int result = 0;
        HashSet<int> hs = new HashSet<int>(nums);

        foreach(var num in nums)
        {
            if(!hs.Contains(num-1))
            {
                int longest = 1;
                while(hs.Contains(num+longest))
                    longest++;
                
                result = Math.Max(result, longest);
            }
        }

        return result;
    }
}
