/*
 * @lc app=leetcode.cn id=1614 lang=csharp
 *
 * [1614] 括号的最大嵌套深度
 */

// @lc code=start
public class Solution
{
    public int MaxDepth(string s)
    {
        int currentDepth = 0, maxDepth = 0;
        foreach (char c in s)
        {
            if (c == '(')
            {
                currentDepth++;
                maxDepth = Math.Max(maxDepth, currentDepth);
            }
            else if (c == ')')
            {
                currentDepth--;
            }
        }
        return maxDepth;
    }
}
// @lc code=end

