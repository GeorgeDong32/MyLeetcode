/*
 * @lc app=leetcode.cn id=1046 lang=csharp
 *
 * [1046] 最后一块石头的重量
 */

// @lc code=start
public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        foreach (var stone in stones)
        {
            pq.Enqueue(stone, stone);
        }
        while (pq.Count > 1)
        {
            var a = pq.Dequeue();
            var b = pq.Dequeue();
            var temp = a - b;
            pq.Enqueue(temp, temp);
        }
        return pq.Count == 0 ? 0 : pq.Dequeue();
    }
}
// @lc code=end

