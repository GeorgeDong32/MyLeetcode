/*
 * @lc app=leetcode.cn id=1974 lang=csharp
 * @lcpr version=30118
 *
 * [1974] 使用特殊打字机键入单词的最少时间
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinTimeToType(string word)
    {
        int time = 0;
        char current = 'a';
        foreach (char c in word)
        {
            int diff = Math.Abs(c - current);
            time += Math.Min(diff, 26 - diff) + 1;
            current = c;
        }
        return time;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abc"\n
// @lcpr case=end

// @lcpr case=start
// "bza"\n
// @lcpr case=end

// @lcpr case=start
// "zjpc"\n
// @lcpr case=end

 */

