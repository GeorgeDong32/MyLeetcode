/*
 * @lc app=leetcode.cn id=1827 lang=csharp
 * @lcpr version=30117
 *
 * [1827] 最少操作使数组递增
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinOperations(int[] nums)
    {
        if (nums.Length == 1)
            return 0;
        int operations = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nums[i - 1])
            {
                int increment = nums[i - 1] - nums[i] + 1;
                operations += increment;
                nums[i] += increment;
            }
        }
        return operations;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,5,2,4,1]\n
// @lcpr case=end

// @lcpr case=start
// [8]\n
// @lcpr case=end

 */

