/*
 * @lc app=leetcode.cn id=1696 lang=csharp
 *
 * [1696] 跳跃游戏 VI
 */

// @lc code=start
public class Solution
{
    public int MaxResult(int[] nums, int k)
    {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, int.MinValue);
        dp[0] = nums[0];
        LinkedList<int> good = new LinkedList<int>();
        good.AddLast(nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = good.First.Value + nums[i];
            while (good.Count > 0 && good.Last.Value < dp[i])
            {
                good.RemoveLast();
            }
            good.AddLast(dp[i]);
            int expireIndex = i - k;
            if (expireIndex >= 0)
            {
                if (good.First.Value == dp[expireIndex])
                {
                    good.RemoveFirst();
                }
            }
        }
        return dp[nums.Length - 1];
    }
}
// @lc code=end

