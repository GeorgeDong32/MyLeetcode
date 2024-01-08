/*
 * @lc app=leetcode.cn id=2651 lang=csharp
 *
 * [2651] 计算列车到站时间
 */

// @lc code=start
public class Solution
{
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
    {
        var temp = arrivalTime + delayedTime;
        return temp > 23 ? temp - 24 : temp;
    }
}
// @lc code=end

