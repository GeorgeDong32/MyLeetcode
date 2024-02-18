/*
 * @lc app=leetcode.cn id=1800 lang=csharp
 * @lcpr version=30116
 *
 * [1800] 最大升序子数组和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxAscendingSum(int[] nums)
    {
        var ans = 0;
        var sum = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                sum += nums[i];
            }
            else
            {
                ans = Math.Max(ans, sum);
                sum = nums[i];
            }
        }
        ans = Math.Max(ans, sum);
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [10,20,30,5,10,50]\n
// @lcpr case=end

// @lcpr case=start
// [10,20,30,40,50]\n
// @lcpr case=end

// @lcpr case=start
// [12,17,15,13,10,11,12]\n
// @lcpr case=end

// @lcpr case=start
// [100,10,1]\n
// @lcpr case=end

 */

