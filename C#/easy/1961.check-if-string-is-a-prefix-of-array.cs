/*
 * @lc app=leetcode.cn id=1961 lang=csharp
 * @lcpr version=30118
 *
 * [1961] 检查字符串是否为数组前缀
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public bool IsPrefixString(string s, string[] words)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < words.Length; i++)
        {
            sb.Append(words[i]);
            if (sb.ToString() == s)
                return true;
        }
        return false;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "iloveleetcode"\n["i","love","leetcode","apples"]\n
// @lcpr case=end

// @lcpr case=start
// "iloveleetcode"\n["apples","i","love","leetcode"]\n
// @lcpr case=end

 */

