/*
 * @lc app=leetcode.cn id=1184 lang=csharp
 *
 * [1184] 公交站间的距离
 */

// @lc code=start

public class Solution
{
    public int DistanceBetweenBusStops(int[] distance, int start, int destination)
    {

        if (start == destination)
        {
            return 0;
        }
        if (start > destination)
        {
            int temp = start;
            start = destination;
            destination = temp;
        }
        int sum = 0;
        int sum1 = 0;
        for (int i = 0; i < distance.Length; i++)
        {
            if (i >= start && i <= destination - 1)
            {
                sum1 += distance[i];
            }
            sum += distance[i];
        }

        return sum1 < (sum - sum1) ? sum1 : (sum - sum1);
    }
}
// @lc code=end

