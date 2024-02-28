/*
 * @lc app=leetcode.cn id=1844 lang=csharp
 * @lcpr version=30117
 *
 * [1844] 将所有数字用字符替换
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Diagnostics;
using System.Text;

public class Solution
{
    public string ReplaceDigits(string s)
    {
        var sb = new StringBuilder();
        for (var i = 1; i < s.Length; i += 2)
        {
            sb.Append(s[i - 1]);
            sb.Append(Shift(s[i - 1], s[i]));
        }
        if (s.Length % 2 == 1)
            sb.Append(s[s.Length - 1]);
        return sb.ToString();
    }

    private char Shift(char c, char x)
    {
        var check = c - 'a' + x - '0';
        Debug.Assert(check <= 26 && check >= 0);
        return (char)('a' + check);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "a1c1e1"\n
// @lcpr case=end

// @lcpr case=start
// "a1b2c3d4e"\n
// @lcpr case=end

 */

