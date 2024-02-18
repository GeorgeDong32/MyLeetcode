/*
 * @lc app=leetcode.cn id=2273 lang=csharp
 * @lcpr version=30116
 *
 * [2273] 移除字母异位词后的结果数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public IList<string> RemoveAnagrams(string[] words)
    {
        IList<string> res = new List<string>();
        foreach (string w in words)
        {
            if (res.Count > 0)
            {
                if (!IsSameString(w, res[res.Count - 1]))
                    res.Add(w);
            }
            else res.Add(w);
        }
        return res;
    }

    private bool IsSameString(string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;

        int[] cnt = new int[26];
        for (int i = 0; i < str1.Length; i++)
        {
            cnt[str1[i] - 'a']++;
            cnt[str2[i] - 'a']--;
        }

        for (int i = 0; i < 26; i++)
            if (cnt[i] != 0) return false;

        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["abba","baba","bbaa","cd","cd"]\n
// @lcpr case=end

// @lcpr case=start
// ["a","b","c","d","e"]\n
// @lcpr case=end

 */

