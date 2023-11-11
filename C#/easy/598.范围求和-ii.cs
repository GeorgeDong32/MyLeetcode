/*
 * @lc app=leetcode.cn id=598 lang=csharp
 *
 * [598] 范围求和 II
 */

// @lc code=start
public class Solution
{
    public int MaxCount(int m, int n, int[][] ops)
    {
        var mina = m; var minb = n;
        foreach (var op in ops)
        {
            mina = Math.Min(op[0], mina);
            minb = Math.Min(op[1], minb);
        }
        return mina * minb;
    }
}
// @lc code=end

