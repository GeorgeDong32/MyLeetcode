/*
 * @lc app=leetcode.cn id=1332 lang=csharp
 *
 * [1332] 删除回文子序列
 */

// @lc code=start
using System.Collections.Immutable;

public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        var sa = s.ToCharArray();
        Array.Reverse(sa);
        var re = new string(sa);
        if (re == s)
            return 1;
        return 2;
    }
}
// @lc code=end

