/*
 * @lc app=leetcode.cn id=2542 lang=csharp
 * @lcpr version=30122
 *
 * [2542] 最大子序列的分数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        /*将nums2从大到小排序，需要选择k个元素，则从第k个开始往后选择
        同时将前面已选择的最小元素不断删除
        */
        var n = nums1.Length;
        long sum = 0, ans = 0;
        var id = Enumerable.Range(0, n).ToArray();
        //将索引按照num2元素从大到小排序
        Array.Sort(id, (a, b) => nums2[b] - nums2[a]);
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < n; i++)
        {
            int v1 = nums1[id[i]];
            int v2 = nums2[id[i]];
            pq.Enqueue(v1, v1);
            sum += v1;
            if (i >= k - 1)   //元素数量达到k个
            {
                ans = Math.Max(ans, sum * v2);  //更新最大值
                sum -= pq.Dequeue();        //删除最小元素
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,3,2]\n[2,1,3,4]\n3\n
// @lcpr case=end

// @lcpr case=start
// [4,2,3,1,1]\n[7,5,10,9,6]\n1\n
// @lcpr case=end

 */

