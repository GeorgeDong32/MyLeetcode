/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 */

// @lc code=start
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var fast = 0; var slow = 0;
        while (fast < nums.Length)
        {
            if (nums[fast] != 0)
            {
                var temp = nums[fast];
                nums[fast] = nums[slow];
                nums[slow] = temp;
                slow++;
            }
            fast++;
        }
    }
}
// @lc code=end

