/*
 * @lc app=leetcode.cn id=2490 lang=csharp
 * @lcpr version=30121
 *
 * [2490] 回环句
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsCircularSentence(string sentence)
    {
        int n = sentence.Length;
        if (sentence[0] != sentence[n - 1])
        {
            return false;
        }
        char prev = ' ';
        for (int i = 0; i < n; i++)
        {
            char curr = sentence[i];
            if (i > 0 && sentence[i - 1] == ' ' && curr != prev)
            {
                return false;
            }
            if (i + 1 < n && sentence[i + 1] == ' ')
            {
                prev = curr;
            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "leetcode exercises sound delightful"\n
// @lcpr case=end

// @lcpr case=start
// "eetcode"\n
// @lcpr case=end

// @lcpr case=start
// "Leetcode is cool"\n
// @lcpr case=end

 */

