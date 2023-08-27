/*
 * @lc app=leetcode.cn id=461 lang=csharp
 *
 * [461] 汉明距离
 */

// @lc code=start
using System.Numerics;

public class Solution
{
    public int HammingDistance(int x, int y)
    {
        return BitOperations.PopCount((uint)(x ^ y));
    }
}
// @lc code=end

