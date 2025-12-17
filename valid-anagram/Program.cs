namespace valid_anagram;

class Program
{
    static void Main(string[] args)
    {
        //https://leetcode.com/problems/valid-anagram/
        Console.WriteLine(IsAnagram("anagram","nagaram"));
    }

    public static bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        IDictionary<char, int> src = BuildDictonary(s.ToArray());
        IDictionary<char, int> target = BuildDictonary(t.ToArray());

        foreach(var itr in src)
        {
            if(!target.ContainsKey(itr.Key) || src[itr.Key] != target[itr.Key])
                return false;
        }
        return true;

        //Alternate solution
        /*if (s.Length != t.Length) {
            return false;
        }

        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int c in count) {
            if (c != 0) {
                return false;
            }
        }

        return true;*/
    }

    private static IDictionary<char, int> BuildDictonary(char[] data)
    {
        IDictionary<char, int> result = new Dictionary<char, int>();
        Array.Sort(data);

        foreach(var itr in data)
        {
            if(!result.ContainsKey(itr))
                result.Add(itr, 1);
            else
                result[itr]++;
        }
        return result;
    }
}
