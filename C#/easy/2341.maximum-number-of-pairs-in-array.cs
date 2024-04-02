/*
 * @lc app=leetcode.cn id=2341 lang=csharp
 * @lcpr version=30121
 *
 * [2341] 数组能形成多少数对
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] NumberOfPairs(int[] nums)
    {
        var gps = nums.GroupBy(x => x);
        var count = 0;
        foreach (var g in gps)
        {
            count += g.Count() / 2;
        }
        return [count, nums.Length - count * 2];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,2,1,3,2,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,1]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */

