/*
 * @lc app=leetcode.cn id=724 lang=csharp
 * @lcpr version=30122
 *
 * [724] 寻找数组的中心下标
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var prefix = new int[nums.Length];
        prefix[0] = 0;
        var sum = nums.Sum();
        for (var i = 0; i < nums.Length - 1; i++)
        {
            prefix[i + 1] = prefix[i] + nums[i];
            if (sum - prefix[i] - nums[i] == prefix[i])
                return i;
        }
        if (prefix[nums.Length - 1] == 0)
            return nums.Length - 1;
        return -1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1, 7, 3, 6, 5, 6]\n
// @lcpr case=end

// @lcpr case=start
// [1, 2, 3]\n
// @lcpr case=end

// @lcpr case=start
// [2, 1, -1]\n
// @lcpr case=end

 */

