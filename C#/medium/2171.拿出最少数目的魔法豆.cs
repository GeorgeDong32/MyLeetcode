/*
 * @lc app=leetcode.cn id=2171 lang=csharp
 *
 * [2171] 拿出最少数目的魔法豆
 */

// @lc code=start
public class Solution
{
    public long MinimumRemoval(int[] beans)
    {
        int n = beans.Length;
        Array.Sort(beans);
        long total = 0;
        for (int i = 0; i < n; i++)
        {
            total += beans[i];
        }
        long res = total;
        for (int i = 0; i < n; i++)
        {
            res = Math.Min(res, total - (long)beans[i] * (n - i));
        }
        return res;
    }
}
// @lc code=end

