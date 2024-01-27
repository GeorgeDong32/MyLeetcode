/*
 * @lc app=leetcode.cn id=2859 lang=csharp
 *
 * [2859] 计算 K 置位下标对应元素的和
 */

// @lc code=start
using System.Xml.Schema;

public class Solution
{
    public int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        return nums.Where((x, i) => System.Numerics.BitOperations.PopCount((uint)i) == k).Sum();
    }
}
// @lc code=end

