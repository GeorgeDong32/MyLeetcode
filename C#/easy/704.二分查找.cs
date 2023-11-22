/*
 * @lc app=leetcode.cn id=704 lang=csharp
 *
 * [704] 二分查找
 */

// @lc code=start
public class Solution
{
    public int Search(int[] nums, int target)
    {
        var res = Array.BinarySearch(nums, target);
        return res >= 0 ? res : -1;
    }
}
// @lc code=end

