/*
 * @lc app=leetcode.cn id=1518 lang=csharp
 *
 * [1518] 换水问题
 */

// @lc code=start
public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        return (numBottles - 1) / (numExchange - 1) + numBottles;
    }
}
// @lc code=end

