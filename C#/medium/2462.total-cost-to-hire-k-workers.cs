/*
 * @lc app=leetcode.cn id=2462 lang=csharp
 * @lcpr version=30122
 *
 * [2462] 雇佣 K 位工人的总代价
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public long TotalCost(int[] costs, int k, int candidates)
    {
        long total = 0;
        PriorityQueue<Tuple<int, int>, long> pq = new PriorityQueue<Tuple<int, int>, long>();
        int n = costs.Length;
        int left = candidates - 1;
        int right = Math.Max(n - candidates, left + 1);
        for (int i = 0; i <= left; i++)
        {
            pq.Enqueue(new Tuple<int, int>(costs[i], i), (long)costs[i] * n + i);
        }
        for (int i = right; i < n; i++)
        {
            pq.Enqueue(new Tuple<int, int>(costs[i], i), (long)costs[i] * n + i);
        }
        for (int i = 0; i < k; i++)
        {
            Tuple<int, int> tuple = pq.Dequeue();
            int cost = tuple.Item1, index = tuple.Item2;
            total += cost;
            if (right - left > 1)
            {
                if (index <= left)
                {
                    left++;
                    pq.Enqueue(new Tuple<int, int>(costs[left], left), (long)costs[left] * n + left);
                }
                else
                {
                    right--;
                    pq.Enqueue(new Tuple<int, int>(costs[right], right), (long)costs[right] * n + right);
                }
            }
        }
        return total;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [17,12,10,2,7,2,11,20,8]\n3\n4\n
// @lcpr case=end

// @lcpr case=start
// [1,2,4,1]\n3\n3\n
// @lcpr case=end

 */

