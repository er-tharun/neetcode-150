namespace trapping_rain_water;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/trapping-rain-water/
        Console.WriteLine(Trap(new int[] {0,1,0,2,1,0,1,3,2,1,2,1}));
    }

    public static int Trap(int[] height) {
        int l = 0;
        int r = height.Length - 1;

        int result = 0;

        int leftMax = height[l];
        int rightMax = height[r];

        while(l<r)
        {
            if(leftMax < rightMax)
            {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                result += leftMax - height[l];
            }
            else
            {
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                result += rightMax - height[r];
            }
        }
        return result;
    }
}
