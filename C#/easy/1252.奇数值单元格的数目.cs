/*
 * @lc app=leetcode.cn id=1252 lang=csharp
 *
 * [1252] 奇数值单元格的数目
 */

// @lc code=start
public class Solution
{
    public int OddCells(int m, int n, int[][] indices)
    {
        var rows = new int[m];
        var cols = new int[n];
        foreach (var i in indices)
        {
            rows[i[0]]++;
            cols[i[1]]++;
        }
        var ans = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (((rows[i] + cols[j]) & 1) != 0)
                {
                    ans++;
                }
            }
        }
        return ans;
    }
}
// @lc code=end

