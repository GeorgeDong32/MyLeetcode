/*
 * @lc app=leetcode.cn id=2239 lang=csharp
 * @lcpr version=30120
 *
 * [2239] 找到最接近 0 的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindClosestNumber(int[] nums)
    {
        var closest = nums.Min(x => Math.Abs(x));
        return nums.Where(x => Math.Abs(x) == closest).Max();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [-4,-2,1,4,8]\n
// @lcpr case=end

// @lcpr case=start
// [2,-1,1]\n
// @lcpr case=end

 */

