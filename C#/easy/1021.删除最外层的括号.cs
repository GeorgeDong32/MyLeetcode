/*
 * @lc app=leetcode.cn id=1021 lang=csharp
 *
 * [1021] 删除最外层的括号
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string RemoveOuterParentheses(string s)
    {
        int level = 0;
        StringBuilder res = new StringBuilder();
        foreach (char c in s)
        {
            if (c == ')')
            {
                level--;
            }
            if (level > 0)
            {
                res.Append(c);
            }
            if (c == '(')
            {
                level++;
            }
        }
        return res.ToString();
    }
}
// @lc code=end

