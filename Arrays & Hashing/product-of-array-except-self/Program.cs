namespace product_of_array_except_self;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/product-of-array-except-self/
        var result = ProductExceptSelf(new int[] {1,2,3,4});
        Console.Write("[");
        foreach(var i in result)
            Console.Write(i + ", ");
        Console.Write("]");
    }

    public static int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        int[] pref = new int[n];
        int[] suff = new int[n];

        pref[0] = 1;
        suff[n-1] = 1;

        for(int i=1; i<n;i++)
            pref[i] = nums[i-1] * pref[i-1];

        for(int i=n-2;i>=0;i--)
            suff[i] = nums[i+1] * suff[i+1];

        for(int i=0; i<n;i++)
            result[i] = pref[i] * suff[i];

        return result;
    }
}
