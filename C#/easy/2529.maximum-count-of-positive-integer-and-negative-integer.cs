/*
 * @lc app=leetcode.cn id=2529 lang=csharp
 * @lcpr version=30121
 *
 * [2529] 正整数和负整数的最大计数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaximumCount(int[] nums)
    {
        return Math.Max(nums.Count(x => x < 0), nums.Count(x => x > 0));
    }
}
// @lc code=end



/*
// @lcpr case=start
// [-2,-1,-1,1,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [-3,-2,-1,0,0,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [5,20,66,1314]\n
// @lcpr case=end

 */

