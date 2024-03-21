/*
 * @lc app=leetcode.cn id=2206 lang=csharp
 * @lcpr version=30119
 *
 * [2206] 将数组划分成相等数对
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool DivideArray(int[] nums)
    {
        return !nums.GroupBy(x => x).Any(g => g.Count() % 2 != 0);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,3,2,2,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4]\n
// @lcpr case=end

 */

