/*
 * @lc app=leetcode.cn id=762 lang=csharp
 *
 * [762] 二进制表示中质数个计算置位
 */

// @lc code=start
public class Solution
{
    public int CountPrimeSetBits(int left, int right)
    {
        var ans = 0;
        for (var i = left; i <= right; i++)
        {
            var str = Convert.ToString(i, 2);
            var num = str.Count(c => c == '1');
            if (num == 2 || num == 3 || num == 5 || num == 7 || num == 11 || num == 13 || num == 17 || num == 19)
            {
                ans++;
            }
        }
        return ans;
    }
}
// @lc code=end

