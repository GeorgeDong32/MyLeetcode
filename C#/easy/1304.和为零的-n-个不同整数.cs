/*
 * @lc app=leetcode.cn id=1304 lang=csharp
 *
 * [1304] 和为零的 N 个不同整数
 */

// @lc code=start
public class Solution
{
    public int[] SumZero(int n)
    {
        var l = new List<int>();
        if (n % 2 == 0)
        {
            for (var i = 1; i <= n / 2; i++)
            {
                l.Add(i);
                l.Add(-i);
            }
        }
        else
        {
            l.Add(0);
            for (var i = 1; i <= n / 2; i++)
            {
                l.Add(i);
                l.Add(-i);
            }
        }
        return l.ToArray();
    }
}
// @lc code=end

