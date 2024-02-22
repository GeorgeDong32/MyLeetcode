/*
 * @lc app=leetcode.cn id=1822 lang=csharp
 * @lcpr version=30117
 *
 * [1822] 数组元素积的符号
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int ArraySign(int[] nums)
    {
        var zero = nums.Any(x => x == 0);
        var neg = nums.Count(x => x < 0) % 2 != 0;
        return zero ? 0 : neg ? -1 : 1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [-1,-2,-3,-4,3,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,5,0,2,-3]\n
// @lcpr case=end

// @lcpr case=start
// [-1,1,-1,1,-1]\n
// @lcpr case=end

 */

