/*
 * @lc app=leetcode.cn id=2558 lang=csharp
 * @lcpr version=30122
 *
 * [2558] 从数量最多的堆取走礼物
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public long PickGifts(int[] gifts, int k)
    {
        var pq = new PriorityQueue<int, int>();
        foreach (var gift in gifts)
        {
            pq.Enqueue(gift, -gift);
        }
        while (k > 0)
        {
            k--;
            var temp = pq.Dequeue();
            pq.Enqueue((int)Math.Sqrt(temp), -(int)Math.Sqrt(temp));
        }
        long ans = 0;
        while (pq.Count > 0)
        {
            ans += pq.Dequeue();
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [25,64,9,4,100]\n4\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,1]\n4\n
// @lcpr case=end

 */

