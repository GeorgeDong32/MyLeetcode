/*
 * @lc app=leetcode.cn id=796 lang=csharp
 *
 * [796] 旋转字符串
 */

// @lc code=start
public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
            return false;
        return (s + s).Contains(goal);
    }
}
// @lc code=end

