namespace two_sum;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/two-sum/
        var result = TwoSum(new int[]{2,7,11,15}, 9);
        Console.WriteLine($"[ {result[0]} , {result[1]} ]");
    }

    public static int[] TwoSum(int[] nums, int target) {
        IDictionary<int, int> hmap = new Dictionary<int, int>();

        int[] result = {-1, -1};

        for(int i=0;i<nums.Length;i++)
        {
            var diff = target - nums[i];
            if(!hmap.ContainsKey(diff))
            {
                if(!hmap.ContainsKey(nums[i]))
                {
                    hmap.Add(nums[i], i);
                }
            }
            else
            {
                result[0] = i;
                result[1] = hmap[diff];
            }
        }

        Array.Sort(result);
        return result;

        //Alternate solution
        /*var map = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++) {
        int complement = target - nums[i];
        if (map.TryGetValue(complement, out int index)) {
            return new int[] { index, i };
        }
        if (!map.ContainsKey(nums[i]));
            map[nums[i]] = i;
            }*/

    }
}
