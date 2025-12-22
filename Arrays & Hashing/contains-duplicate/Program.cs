namespace contains_duplicate;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/contains-duplicate/
        Console.WriteLine(ContainsDuplicate(new int[] {1,2,3,1}));
    }

    public static bool ContainsDuplicate(int[] nums) => new HashSet<int>(nums).Count < nums.Length;
}
