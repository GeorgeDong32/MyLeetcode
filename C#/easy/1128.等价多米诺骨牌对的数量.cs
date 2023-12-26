/*
 * @lc app=leetcode.cn id=1128 lang=csharp
 *
 * [1128] 等价多米诺骨牌对的数量
 */

// @lc code=start
public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        int[,] grid = new int[9, 9];
        int ans = 0;
        for (int i = 0; i < dominoes.Length; i++)
        {
            int j = dominoes[i][0] - 1;
            int k = dominoes[i][1] - 1;
            ans += (j == k ? 0 : grid[k, j]) + grid[j, k]++;
        }
        return ans;
    }
}
// @lc code=end

