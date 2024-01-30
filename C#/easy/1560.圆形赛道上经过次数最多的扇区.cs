/*
 * @lc app=leetcode.cn id=1560 lang=csharp
 *
 * [1560] 圆形赛道上经过次数最多的扇区
 */

// @lc code=start
public class Solution
{
    public IList<int> MostVisited(int n, int[] rounds)
    {
        int[] count = new int[n + 1];
        int len = rounds.Length;
        for (int i = 0; i < len - 1; i++)
        {
            int start = rounds[i], end = rounds[i + 1];
            if (start <= end)
            {
                for (int j = start; j < end; j++)
                {
                    count[j]++;
                }
            }
            else
            {
                for (int j = start; j <= n; j++)
                {
                    count[j]++;
                }
                for (int j = 1; j < end; j++)
                {
                    count[j]++;
                }
            }
        }
        count[rounds[len - 1]]++;
        int maxCount = count.Max();
        return count.Select((x, i) => new { Index = i, Value = x })
                         .Where(x => x.Value == maxCount)
                         .Select(x => x.Index)
                         .ToList();
    }
}
// @lc code=end

