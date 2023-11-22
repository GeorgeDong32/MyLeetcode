/*
 * @lc app=leetcode.cn id=2216 lang=csharp
 *
 * [2216] 美化数组的最少删除数
 */

// @lc code=start
public class Solution
{
    public int MinDeletion(int[] nums)
    {
        var dc = 0; //delete count
        for (var i = 0; i < nums.Length; i++)
        {
            if ((i - dc) % 2 == 0 && i + 1 < nums.Length && nums[i] == nums[i + 1])
                dc++;
        }
        return (nums.Length - dc) % 2 == 0 ? dc : dc + 1;
    }
}
// @lc code=end

