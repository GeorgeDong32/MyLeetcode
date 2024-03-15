/*
 * @lc app=leetcode.cn id=2114 lang=csharp
 * @lcpr version=30119
 *
 * [2114] 句子中的最多单词数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        return sentences.Select(s => s.Split(' ').Length).Max();
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["alice and bob love leetcode", "i think so too", "this is great thanks very much"]\n
// @lcpr case=end

// @lcpr case=start
// ["please wait", "continue to fight", "continue to win"]\n
// @lcpr case=end

 */

