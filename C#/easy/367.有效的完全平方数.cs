/*
 * @lc app=leetcode.cn id=367 lang=csharp
 *
 * [367] 有效的完全平方数
 */

// @lc code=start
public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        double x = Math.Sqrt(num);
        if (x - Math.Round(x) == 0)
            return true;
        else
            return false;
    }
}
// @lc code=end

