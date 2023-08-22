/*
 * @lc app=leetcode.cn id=338 lang=csharp
 *
 * [338] 比特位计数
 */

// @lc code=start
public class Solution
{
    public int[] CountBits(int n)
    {
        var result = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            result[i] = result[i >> 1] + (i & 1);  //注意i&1需要加括号
        }
        return result;
    }
}
// @lc code=end

