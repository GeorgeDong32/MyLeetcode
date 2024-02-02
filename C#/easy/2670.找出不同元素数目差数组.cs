/*
 * @lc app=leetcode.cn id=2670 lang=csharp
 *
 * [2670] 找出不同元素数目差数组
 */

// @lc code=start
public class Solution
{
    public int[] DistinctDifferenceArray(int[] nums)
    {
        return Enumerable.Range(1, nums.Length).Select(i => nums.Take(i).ToHashSet().Count - nums.Skip(i).ToHashSet().Count).ToArray();
    }
}
// @lc code=end

