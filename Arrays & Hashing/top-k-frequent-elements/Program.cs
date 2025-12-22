namespace top_k_frequent_elements;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/top-k-frequent-elements/
        var result = TopKFrequent(new int[] {1,1,1,2,2,3}, 2);

        Array.Sort(result);

        Console.Write("[");
        foreach(var i in result)
            Console.Write(i + ", ");
        Console.Write("]");
    }

    public static int[] TopKFrequent(int[] nums, int k) {
        IDictionary<int, int> freq = new Dictionary<int, int>();

        foreach(var itr in nums)
        {
            if(freq.ContainsKey(itr))
                freq[itr]++;
            else
                freq.Add(itr, 1);
        }

        var pq = new PriorityQueue<int, int>();

        foreach(var itr in freq)
        {
            pq.Enqueue(itr.Key, itr.Value);
            if(pq.Count > k)
                pq.Dequeue();
        }

        int[] result = new int[k];

        for(int i=0;i<k;i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
