/*
 * @lc app=leetcode.cn id=1913 lang=csharp
 * @lcpr version=30117
 *
 * [1913] 两个数对之间的最大乘积差
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        Array.Sort(nums);
        var l = nums.Length;
        return nums[l - 1] * nums[l - 2] - nums[0] * nums[1];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,6,2,7,4]\n
// @lcpr case=end

// @lcpr case=start
// [4,2,5,9,7,4,8]\n
// @lcpr case=end

 */

