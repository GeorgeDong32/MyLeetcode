/*
 * @lc app=leetcode.cn id=496 lang=csharp
 *
 * [496] 下一个更大元素 I
 */

// @lc code=start
using System.Globalization;

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        int m = nums1.Length, n = nums2.Length;
        int[] res = new int[m];
        for (int i = 0; i < m; ++i)
        {
            int j = 0;
            while (j < n && nums2[j] != nums1[i])
            {
                ++j;
            }
            int k = j + 1;
            while (k < n && nums2[k] < nums2[j])
            {
                ++k;
            }
            res[i] = k < n ? nums2[k] : -1;
        }
        return res;
    }
}
// @lc code=end

