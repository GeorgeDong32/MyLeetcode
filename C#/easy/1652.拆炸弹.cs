/*
 * @lc app=leetcode.cn id=1652 lang=csharp
 *
 * [1652] 拆炸弹
 */

// @lc code=start
public class Solution
{
    public int[] Decrypt(int[] code, int k)
    {
        int n = code.Length;
        int[] ans = new int[n];
        if (k == 0)
        {
            return ans;
        }
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            if (k > 0)
            {
                for (int j = 1; j <= k; j++)
                {
                    sum += code[(i + j) % n];
                }
            }
            else
            {
                for (int j = k; j < 0; j++)
                {
                    sum += code[(i + j + n) % n];
                }
            }
            ans[i] = sum;
        }
        return ans;
    }
}
// @lc code=end

