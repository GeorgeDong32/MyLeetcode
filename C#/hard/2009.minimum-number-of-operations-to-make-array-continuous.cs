/*
 * @lc app=leetcode.cn id=2009 lang=csharp
 * @lcpr version=30121
 *
 * [2009] 使数组连续的最少操作数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start

public class Solution
{
    public int MinOperations(int[] nums)
    {
        int ans = int.MaxValue, j = 0, len = nums.Length;
        nums = nums.Distinct().ToArray();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            while (j < nums.Length && nums[j] <= nums[i] + len - 1) j++;
            ans = Math.Min(ans, len - (j - i));
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,2,5,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,5,6]\n
// @lcpr case=end

// @lcpr case=start
// [1,10,100,1000]\n
// @lcpr case=end

 */

