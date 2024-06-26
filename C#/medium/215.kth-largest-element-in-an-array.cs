/*
 * @lc app=leetcode.cn id=215 lang=csharp
 * @lcpr version=30122
 *
 * [215] 数组中的第K个最大元素
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        return nums.OrderByDescending(x => x).Skip(k - 1).Take(1).Single();
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n
// @lcpr case=end

// @lcpr case=start
// 4\n
// @lcpr case=end

 */

