/*
 * @lc app=leetcode.cn id=2016 lang=csharp
 * @lcpr version=30118
 *
 * [2016] 增量元素之间的最大差值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        int maxDiff = 0;
        int minNum = nums[0];
        int n = nums.Length;
        for (int i = 1; i < n; i++)
        {
            maxDiff = Math.Max(maxDiff, nums[i] - minNum);
            minNum = Math.Min(minNum, nums[i]);
        }
        return maxDiff > 0 ? maxDiff : -1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [7,1,5,4]\n
// @lcpr case=end

// @lcpr case=start
// [9,4,3,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,5,2,10]\n
// @lcpr case=end

 */

