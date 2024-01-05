/*
 * @lc app=leetcode.cn id=1365 lang=csharp
 *
 * [1365] 有多少小于当前数字的数字
 */

// @lc code=start
public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        return nums.Select(x => nums.Count(y => x > y)).ToArray();
    }
}
// @lc code=end

