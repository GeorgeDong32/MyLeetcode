/*
 * @lc app=leetcode.cn id=1763 lang=csharp
 * @lcpr version=30116
 *
 * [1763] 最长的美好子字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string LongestNiceSubstring(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string sub = s.Substring(i, j - i);
                if (IsNice(sub) && sub.Length > res.Length)
                {
                    res = sub;
                }
            }
        }
        return res;
    }

    private bool IsNice(string s)
    {
        foreach (char c in s)
        {
            if (char.IsLower(c) && !s.Contains(char.ToUpper(c)) || char.IsUpper(c) && !s.Contains(char.ToLower(c)))
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "YazaAay"\n
// @lcpr case=end

// @lcpr case=start
// "Bb"\n
// @lcpr case=end

// @lcpr case=start
// "c"\n
// @lcpr case=end

// @lcpr case=start
// "dDzeE"\n
// @lcpr case=end

 */

