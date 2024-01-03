/*
 * @lc app=leetcode.cn id=1337 lang=csharp
 *
 * [1337] 矩阵中战斗力最弱的 K 行
 */

// @lc code=start
public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        var p = from arr in mat
                let index = Array.IndexOf(mat, arr)
                orderby arr.Count(item => item == 1), index
                select index
                ;

        return p.Take(k).ToArray();
    }
}
// @lc code=end

