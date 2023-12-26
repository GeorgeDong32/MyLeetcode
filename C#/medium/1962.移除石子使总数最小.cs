/*
 * @lc app=leetcode.cn id=1962 lang=csharp
 *
 * [1962] 移除石子使总数最小
 */

// @lc code=start
public class Solution
{
    public int MinStoneSum(int[] piles, int k)
    {
        var pq = new PriorityQueue<int, int>();
        foreach (var p in piles)
        {
            pq.Enqueue(p, -p);
        }
        for (var i = 0; i < k; i++)
        {
            var p = pq.Dequeue();
            p -= p / 2;
            pq.Enqueue(p, -p);
        }
        var sum = 0;
        while (pq.Count > 0)
        {
            sum += pq.Dequeue();
        }
        return sum;
    }
}
// @lc code=end

