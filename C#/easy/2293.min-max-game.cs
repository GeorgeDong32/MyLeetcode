/*
 * @lc app=leetcode.cn id=2293 lang=csharp
 * @lcpr version=30120
 *
 * [2293] 极大极小游戏
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinMaxGame(int[] nums)
    {
        int n = nums.Length;
        while (n > 1)
        {
            int half = n / 2;
            int[] newNums = new int[half];
            for (int i = 0; i < half; i++)
            {
                if (i % 2 == 0)
                {
                    newNums[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);
                }
                else
                {
                    newNums[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);
                }
            }
            nums = newNums;
            n /= 2;
        }
        return nums[0];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,3,5,2,4,8,2,2]\n
// @lcpr case=end

// @lcpr case=start
// [3]\n
// @lcpr case=end

 */

