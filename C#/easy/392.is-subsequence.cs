/*
 * @lc app=leetcode.cn id=392 lang=csharp
 * @lcpr version=30122
 *
 * [392] 判断子序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        var i = 0; var j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
                i++;
            j++;
        }
        return i == s.Length;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abc"\n"ahbgdc"\n
// @lcpr case=end

// @lcpr case=start
// "axc"\n"ahbgdc"\n
// @lcpr case=end

 */

