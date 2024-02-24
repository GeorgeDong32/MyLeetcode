/*
 * @lc app=leetcode.cn id=1876 lang=csharp
 * @lcpr version=30117
 *
 * [1876] 长度为三且各字符不同的子字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length - 2; i++)
        {
            if (IsGood(s.Substring(i, 3)))
            {
                count++;
            }
        }
        return count;
    }

    private bool IsGood(string s)
    {
        return s[0] != s[1] && s[0] != s[2] && s[1] != s[2];
    }
}
// @lc code=end



/*
// @lcpr case=start
// "xyzzaz"\n
// @lcpr case=end

// @lcpr case=start
// "aababcabc"\n
// @lcpr case=end

 */

