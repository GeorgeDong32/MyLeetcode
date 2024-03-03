/*
 * @lc app=leetcode.cn id=1957 lang=csharp
 * @lcpr version=30117
 *
 * [1957] 删除字符使字符串变好
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string MakeFancyString(string s)
    {
        if (s.Length < 3) return s;
        StringBuilder result = new StringBuilder();
        result.Append(s.Substring(0, 2));
        for (int i = 2; i < s.Length; i++)
        {
            if (s[i] != s[i - 1] || s[i] != s[i - 2])
            {
                result.Append(s[i]);
            }
        }
        return result.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "leeetcode"\n
// @lcpr case=end

// @lcpr case=start
// "aaabaaaa"\n
// @lcpr case=end

// @lcpr case=start
// "aab"\n
// @lcpr case=end

 */

