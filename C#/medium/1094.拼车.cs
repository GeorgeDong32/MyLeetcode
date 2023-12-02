/*
 * @lc app=leetcode.cn id=1094 lang=csharp
 *
 * [1094] 拼车
 */

// @lc code=start
public class Solution
{
    public bool CarPooling(int[][] trips, int capacity)
    {
        int toMax = 0;
        foreach (int[] trip in trips)
        {
            toMax = Math.Max(toMax, trip[2]);
        }

        int[] diff = new int[toMax + 1];
        foreach (int[] trip in trips)
        {
            diff[trip[1]] += trip[0];
            diff[trip[2]] -= trip[0];
        }

        int count = 0;
        for (int i = 0; i <= toMax; ++i)
        {
            count += diff[i];
            if (count > capacity)
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

