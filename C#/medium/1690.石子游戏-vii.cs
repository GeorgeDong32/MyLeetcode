/*
 * @lc app=leetcode.cn id=1690 lang=csharp
 *
 * [1690] 石子游戏 VII
 */

// @lc code=start
public class Solution
{
    public int StoneGameVII(int[] stones)
    {
        int n = stones.Length;
        int[] prefixSums = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            prefixSums[i + 1] = prefixSums[i] + stones[i];
        }
        int[][] dp = new int[n][];
        for (int i = 0; i < n; i++)
        {
            dp[i] = new int[n];
        }
        for (int subLength = 2; subLength <= n; subLength++)
        {
            for (int i = 0, j = subLength - 1; j < n; i++, j++)
            {
                dp[i][j] = Math.Max(GetRangeSum(prefixSums, i + 1, j) - dp[i + 1][j], GetRangeSum(prefixSums, i, j - 1) - dp[i][j - 1]);
            }
        }
        return dp[0][n - 1];
    }

    public int GetRangeSum(int[] prefixSums, int start, int end)
    {
        return prefixSums[end + 1] - prefixSums[start];
    }
}
// @lc code=end

