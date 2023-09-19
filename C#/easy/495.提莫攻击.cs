/*
 * @lc app=leetcode.cn id=495 lang=csharp
 *
 * [495] 提莫攻击
 */

// @lc code=start
public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        var res = 0;
        if (timeSeries.Length == 1)
        {
            return duration;
        }
        for (int i = 1; i < timeSeries.Length; i++)
        {
            // 上一次攻击到当前的时间或是中毒时间
            res += Math.Min(duration, timeSeries[i] - timeSeries[i - 1]);
        }
        //最后一次中毒
        res += duration;
        return res;
    }
}
// @lc code=end

