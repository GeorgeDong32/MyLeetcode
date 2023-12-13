/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start
public class Solution
{
    public int ClimbStairs(int n)
    {
        var roll = new int[3] { 2, 1, 0 };
        if (n <= 2)
            return roll[2 - n];
        for (var i = 3; i < n + 1; i++)
        {
            roll[2] = roll[1];
            roll[1] = roll[0];
            roll[0] = roll[1] + roll[2];
        }
        return roll[0];
    }
}
// @lc code=end

