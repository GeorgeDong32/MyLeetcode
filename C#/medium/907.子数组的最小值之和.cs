/*
 * @lc app=leetcode.cn id=907 lang=csharp
 *
 * [907] 子数组的最小值之和
 */

// @lc code=start
public class Solution
{
    //贡献+单调栈
    public readonly static int MOD = 1000000007;
    public int SumSubarrayMins(int[] arr)
    {
        var n = arr.Length; long count = 0;
        if (arr is null || n == 0)
        {
            return 0;
        }
        for (int i = 0; i < n; i++)
        {
            var val = arr[i];

            int left = 0;
            if (i == 0) left = 1;
            else
            {
                for (int j = i - 1; j >= 0 && val < arr[j]; j--)
                {
                    left++;
                }
                left++;
            }
            int right = 0;
            if (i == n - 1) right = 1;
            else
            {
                for (int j = i + 1; j < n && val <= arr[j]; j++)
                {
                    right++;
                }
                right++;
            }
            count = (count + (long)left * right * val) % MOD;
        }
        return (int)count;
    }
}
// @lc code=end

