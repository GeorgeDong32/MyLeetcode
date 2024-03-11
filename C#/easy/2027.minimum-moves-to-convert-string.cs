/*
 * @lc app=leetcode.cn id=2027 lang=csharp
 * @lcpr version=30119
 *
 * [2027] 转换字符串的最少操作次数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinimumMoves(string s)
    {
        int moves = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'X')
            {
                moves++;
                i += 2;
            }
        }
        return moves;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "XXX"\n
// @lcpr case=end

// @lcpr case=start
// "XXOX"\n
// @lcpr case=end

// @lcpr case=start
// "OOOO"\n
// @lcpr case=end

 */

