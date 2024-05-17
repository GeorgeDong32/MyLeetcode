/*
 * @lc app=leetcode.cn id=347 lang=csharp
 * @lcpr version=30202
 *
 * [347] 前 K 个高频元素
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        foreach (var x in nums)
        {
            dict.TryAdd(x, 0);
            dict[x]++;
        }
        var pq = new PriorityQueue<int, int>();
        foreach (var kv in dict)
        {
            pq.Enqueue(kv.Key, kv.Value);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        var ans = new int[k];
        for (var i = 0; i < k; i++)
        {
            ans[i] = pq.Dequeue();
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,1,2,2,3]\n2\n
// @lcpr case=end

// @lcpr case=start
// [1]\n1\n
// @lcpr case=end

 */

