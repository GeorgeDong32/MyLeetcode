/*
 * @lc app=leetcode.cn id=2605 lang=csharp
 * @lcpr version=30122
 *
 * [2605] 从两个数字数组里生成最小数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinNumber(int[] nums1, int[] nums2)
    {
        var common = nums1.Intersect(nums2).ToArray();
        var min1 = nums1.Min(); var min2 = nums2.Min();
        return common.Length > 0 ? common.Min() : Math.Min(min1 * 10 + min2, min2 * 10 + min1);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,1,3]\n[5,7]\n
// @lcpr case=end

// @lcpr case=start
// [3,5,2,6]\n[3,1,7]\n
// @lcpr case=end

 */

