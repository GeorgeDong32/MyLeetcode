/*
 * @lc app=leetcode.cn id=643 lang=csharp
 * @lcpr version=30122
 *
 * [643] 子数组最大平均数 I
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;
        for (var i = 0; i < k; i++)
        {
            sum += nums[i];
        }
        double max = sum;
        for (var i = k; i < nums.Length; i++)
        {
            sum = sum - nums[i - k] + nums[i];
            max = sum > max ? sum : max;
        }
        return max / k;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,12,-5,-6,50,3]\n4\n
// @lcpr case=end

// @lcpr case=start
// [5]\n1\n
// @lcpr case=end

 */

