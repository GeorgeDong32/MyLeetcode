/*
 * @lc app=leetcode.cn id=239 lang=csharp
 * @lcpr version=30201
 *
 * [239] 滑动窗口最大值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) return new int[0];
        var ans = new List<int>();
        var deque = new LinkedList<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            while (deque.Count > 0 && nums[i] > nums[deque.Last.Value])
            {
                deque.RemoveLast();
            }
            deque.AddLast(i);
            if (deque.First.Value < i - k + 1)
            {
                deque.RemoveFirst();
            }
            if (i >= k - 1)
            {
                ans.Add(nums[deque.First.Value]);
            }
        }
        return ans.ToArray();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,-1,-3,5,3,6,7]\n3\n
// @lcpr case=end

// @lcpr case=start
// [1]\n1\n
// @lcpr case=end

 */

