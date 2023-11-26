/*
 * @lc app=leetcode.cn id=747 lang=csharp
 *
 * [747] 至少是其他数字两倍的最大数
 */

// @lc code=start
public class Solution
{
    public int DominantIndex(int[] nums)
    {
        var l = nums.Length; var newnums = new int[l];
        Array.Copy(nums, newnums, l);
        Array.Sort(newnums);
        if (newnums[l - 1] >= newnums[l - 2] * 2)
            return Array.IndexOf(nums, newnums[l - 1]);
        return -1;
    }
}
// @lc code=end

