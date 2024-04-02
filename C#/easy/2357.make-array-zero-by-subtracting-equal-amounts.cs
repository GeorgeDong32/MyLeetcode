/*
 * @lc app=leetcode.cn id=2357 lang=csharp
 * @lcpr version=30121
 *
 * [2357] 使数组中所有元素都等于零
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        return nums.Distinct().Count(x => x != 0);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,5,0,3,5]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */

