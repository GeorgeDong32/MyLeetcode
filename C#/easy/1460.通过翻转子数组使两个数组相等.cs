/*
 * @lc app=leetcode.cn id=1460 lang=csharp
 *
 * [1460] 通过翻转子数组使两个数组相等
 */

// @lc code=start
public class Solution
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        Array.Sort(target);
        Array.Sort(arr);
        return target.SequenceEqual(arr);
    }
}
// @lc code=end

