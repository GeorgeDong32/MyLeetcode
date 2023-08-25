/*
 * @lc app=leetcode.cn id=448 lang=csharp
 *
 * [448] 找到所有数组中消失的数字
 */

// @lc code=start
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var ans = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[Math.Abs(nums[i]) - 1] = -Math.Abs(nums[Math.Abs(nums[i]) - 1]);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                ans.Add(i + 1);
        }
        return ans;
    }
}
// @lc code=end

