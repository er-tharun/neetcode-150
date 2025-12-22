using System.Text;

namespace group_anagrams;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/group-anagrams/
        var result = GroupAnagrams(new string[] {"eat","tea","tan","ate","nat","bat"});
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        foreach(var itr1 in result)
        {
            sb.Append("[");
            foreach(var itr2 in itr1)
            {
                sb.Append("\"" + itr2 + "\"" + " ");
            }
            sb.Append("]");
        }
        sb.Append("]");

        Console.WriteLine(sb.ToString());
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs) {
        
        var result = new Dictionary<string, List<string>>();

        foreach(var s in strs)
        {
            int[] charCount = new int[26];
            foreach(var itr in s.ToCharArray())
            {
                charCount[itr - 'a']++;
            }

            string key = string.Join(",", charCount);

            if(!result.ContainsKey(key))
                result.Add(key, new List<string>());
            result[key].Add(s);
        }

        return result.Values.ToList<IList<string>>();
    }
}
