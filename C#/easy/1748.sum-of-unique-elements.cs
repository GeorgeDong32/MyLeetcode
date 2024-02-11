/*
 * @lc app=leetcode.cn id=1748 lang=csharp
 * @lcpr version=30116
 *
 * [1748] 唯一元素的和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        return nums.GroupBy(x => x)
            .Where(g => g.Count() == 1)
            .Sum(g => g.Key);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,1,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,5]\n
// @lcpr case=end

 */

