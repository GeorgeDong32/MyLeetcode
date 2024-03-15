/*
 * @lc app=leetcode.cn id=2789 lang=csharp
 * @lcpr version=30119
 *
 * [2789] 合并后数组中的最大元素
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public long MaxArrayValue(int[] nums)
    {
        long maxValue = 0;
        long currValue = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            currValue = nums[i] <= currValue ? nums[i] + currValue : nums[i];
            maxValue = Math.Max(maxValue, currValue);
        }
        return maxValue;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,3,7,9,3]\n
// @lcpr case=end

// @lcpr case=start
// [5,3,3]\n
// @lcpr case=end

 */

