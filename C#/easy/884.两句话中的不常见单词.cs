/*
 * @lc app=leetcode.cn id=884 lang=csharp
 *
 * [884] 两句话中的不常见单词
 */

// @lc code=start
public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var split1 = s1.Split(' ');
        var split2 = s2.Split(' ');
        var dict1 = new Dictionary<string, int>();
        var dict2 = new Dictionary<string, int>();
        var ans = new HashSet<string>();
        foreach (var w in split1)
        {
            if (!dict1.ContainsKey(w))
            {
                dict1.Add(w, 1);
            }
            else
                dict1[w]++;
        }
        foreach (var w in split2)
        {
            if (!dict2.ContainsKey(w))
            {
                dict2.Add(w, 1);
            }
            else
                dict2[w]++;
        }
        foreach (var kv in dict1)
        {
            if (kv.Value == 1)
            {
                if (!dict2.ContainsKey(kv.Key))
                    ans.Add(kv.Key);
            }
        }
        foreach (var kv in dict2)
        {
            if (kv.Value == 1)
            {
                if (!dict1.ContainsKey(kv.Key))
                    ans.Add(kv.Key);
            }
        }
        return ans.ToArray();
    }
}
// @lc code=end

