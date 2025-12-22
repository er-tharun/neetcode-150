namespace container_with_most_water;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/container-with-most-water/
        Console.WriteLine(MaxArea(new int[] {1,8,6,2,5,4,8,3,7}));
    }

    public static int MaxArea(int[] height) 
    {
        int l = 0;
        int r = height.Length-1;
        int result = 0;

        while(l < r)
        {
            result = Math.Max(result, (Math.Min(height[l], height[r]) * (r - l)));
            if(height[l] <= height[r])
                l++;
            else
                r--;
        }

        return result;
    }
}
