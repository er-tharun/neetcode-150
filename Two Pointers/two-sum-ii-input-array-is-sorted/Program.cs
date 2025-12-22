namespace two_sum_ii_input_array_is_sorted;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        var result = TwoSum(new int[] {2,7,11,15}, 9);

        Console.Write("[");
        foreach(var data in result)
        {
            Console.Write($" {data} ");
        }
        Console.Write("]");
    }

    public static int[] TwoSum(int[] numbers, int target) {
        /*IDictionary<int, int> freq = new Dictionary<int, int>();

        for(int i=0; i<numbers.Length;i++)
        {
            int diff = target - numbers[i];
            if(freq.ContainsKey(diff))
            {
                return new int[] {freq[diff], i+1};
            }
            if(!freq.ContainsKey(numbers[i]))
                freq.Add(numbers[i], i+1);
            else
                freq[numbers[i]] = i+1;
        }
        return new int[] {-1, -1};*/

        int l = 0;
        int r = numbers.Length - 1;

        while(l < r)
        {
            int sum = numbers[l] + numbers[r];
            if(sum > target)
                r--;
            else if(sum < target)
                l++;
            else
                return new int[] {l+1, r+1};
        }
        return new int[] {-1, -1};
    }
}
