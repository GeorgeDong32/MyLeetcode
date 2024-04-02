/*
 * @lc app=leetcode.cn id=2395 lang=csharp
 * @lcpr version=30121
 *
 * [2395] 和相等的子数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool FindSubarrays(int[] nums)
    {
        var set = new HashSet<int>();
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (!set.Add(nums[i] + nums[i + 1]))
                return true;
        }
        return false;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,2,4]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,5]\n
// @lcpr case=end

// @lcpr case=start
// [0,0,0]\n
// @lcpr case=end

 */

