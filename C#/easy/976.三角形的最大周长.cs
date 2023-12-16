/*
 * @lc app=leetcode.cn id=976 lang=csharp
 *
 * [976] 三角形的最大周长
 */

// @lc code=start
public class Solution
{
    public int LargestPerimeter(int[] nums)
    {
        int len = nums.Length, p = len - 3;
        Array.Sort(nums);
        while (p >= 0)
        {
            if (nums[p] + nums[p + 1] > nums[p + 2])
            {
                return nums[p] + nums[p + 1] + nums[p + 2];
            }
            p--;
        }
        return 0;
    }
}
// @lc code=end

