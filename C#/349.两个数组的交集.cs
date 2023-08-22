/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 */

// @lc code=start
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var res = new HashSet<int>();
        foreach (var num in nums1)
        {
            if (Array.IndexOf(nums2, num) >= 0)
            {
                res.Add(num);
            }
        }
        return res.ToArray();
    }
}
// @lc code=end

