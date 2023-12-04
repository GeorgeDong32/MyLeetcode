/*
 * @lc app=leetcode.cn id=868 lang=csharp
 *
 * [868] 二进制间距
 */

// @lc code=start
public class Solution
{
    public int BinaryGap(int n)
    {
        int last = -1; int ans = 0;
        for (var i = 0; n != 0; i++)
        {
            if ((n & 1) == 1)
            {
                if (last != -1)
                {
                    ans = Math.Max(ans, i - last);
                }
                last = i;
            }
            n >>= 1;
        }
        return ans;
    }
}
// @lc code=end

