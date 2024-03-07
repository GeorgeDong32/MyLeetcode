/*
 * @lc app=leetcode.cn id=2917 lang=csharp
 * @lcpr version=30118
 *
 * [2917] 找出数组中的 K-or 值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int FindKOr(int[] nums, int k)
    {
        return Enumerable.Range(0, 32)
            .Select(i => 1 << i)
            .Where(bit => nums.Count(num => (num & bit) != 0) >= k)
            .Aggregate(0, (acc, bit) => acc | bit);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [7,12,9,8,9,15]\n4\n
// @lcpr case=end

// @lcpr case=start
// [2,12,1,11,4,5]\n6\n
// @lcpr case=end

// @lcpr case=start
// [10,8,5,9,11,6,8]\n1\n
// @lcpr case=end

 */

