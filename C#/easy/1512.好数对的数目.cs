/*
 * @lc app=leetcode.cn id=1512 lang=csharp
 *
 * [1512] 好数对的数目
 */

// @lc code=start
public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        return nums.GroupBy(num => num)
                    .Sum(group => group.Count() * (group.Count() - 1) / 2);
    }
}
// @lc code=end

