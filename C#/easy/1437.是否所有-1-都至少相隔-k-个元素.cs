/*
 * @lc app=leetcode.cn id=1437 lang=csharp
 *
 * [1437] 是否所有 1 都至少相隔 k 个元素
 */

// @lc code=start
public class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        int prevOneIndex = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (prevOneIndex != -1 && i - prevOneIndex - 1 < k)
                {
                    return false;
                }
                prevOneIndex = i;
            }
        }
        return true;
    }
}
// @lc code=end

