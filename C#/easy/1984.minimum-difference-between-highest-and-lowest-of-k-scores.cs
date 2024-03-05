/*
 * @lc app=leetcode.cn id=1984 lang=csharp
 * @lcpr version=30118
 *
 * [1984] 学生分数的最小差值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumDifference(int[] nums, int k)
    {
        if (k == 1 || nums.Length == 1)
            return 0;
        Array.Sort(nums);
        var mindiff = 99999999;
        for (var i = 0; i < nums.Length - k + 1; i++)
        {
            mindiff = Math.Min(mindiff, nums[i + (k - 1)] - nums[i]);
        }
        return mindiff;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [90]\n1\n
// @lcpr case=end

// @lcpr case=start
// [9,4,1,7]\n2\n
// @lcpr case=end

 */

