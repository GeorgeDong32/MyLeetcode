/*
 * @lc app=leetcode.cn id=1221 lang=csharp
 *
 * [1221] 分割平衡字符串
 */

// @lc code=start
public class Solution
{
    public int BalancedStringSplit(string s)
    {
        var ans = 0; var count = 0;
        foreach (var c in s)
        {
            switch (c)
            {
                case 'L': count++; break;
                case 'R': count--; break;
                default: count += 0; break;
            }
            if (count == 0)
                ans++;
        }
        return ans;
    }
}
// @lc code=end

