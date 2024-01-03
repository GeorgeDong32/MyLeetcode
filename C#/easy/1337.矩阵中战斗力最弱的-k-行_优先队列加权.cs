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
        var pq = new PriorityQueue<int, float>();
        for (var i = 0; i < mat.Length; i++)
        {
            pq.Enqueue(i, mat[i].Sum() + 0.001f * i);
        }
        var ans = new List<int>();
        for (var i = 0; i < k; i++)
        {
            ans.Add(pq.Dequeue());
        }
        return ans.ToArray();
    }
}
// @lc code=end

