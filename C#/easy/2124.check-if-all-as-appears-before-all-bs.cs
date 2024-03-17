/*
 * @lc app=leetcode.cn id=2124 lang=csharp
 * @lcpr version=30119
 *
 * [2124] 检查是否所有 A 都在 B 之前
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckString(string s)
    {
        var lasta = -1;
        var firstb = -1;
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
                lasta = i;
            if (s[i] == 'b' && firstb == -1)
                firstb = i;
        }
        return lasta < firstb ? true : (firstb == -1);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "aaabbb"\n
// @lcpr case=end

// @lcpr case=start
// "abab"\n
// @lcpr case=end

// @lcpr case=start
// "bbb"\n
// @lcpr case=end

 */

