/*
 * @lc app=leetcode.cn id=922 lang=csharp
 *
 * [922] 按奇偶排序数组 II
 */

// @lc code=start
public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        int j = 1;
        for (int i = 0; i < nums.Length; i += 2)
        {
            if (nums[i] % 2 == 1)
            {
                while (nums[j] % 2 == 1)
                {
                    j += 2;
                }
                nums[i] ^= nums[j];
                nums[j] ^= nums[i];
                nums[i] ^= nums[j];
            }
        }
        return nums;
    }
}
// @lc code=end

