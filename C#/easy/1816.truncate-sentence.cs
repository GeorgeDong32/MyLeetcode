/*
 * @lc app=leetcode.cn id=1816 lang=csharp
 * @lcpr version=30116
 *
 * [1816] 截断句子
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        var split = s.Split(' ');
        split = split.Take(k).ToArray();
        return string.Join(" ", split);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "Hello how are you Contestant"\n4\n
// @lcpr case=end

// @lcpr case=start
// "What is the solution to this problem"\n4\n
// @lcpr case=end

// @lcpr case=start
// "chopper is not a tanuki"\n5\n
// @lcpr case=end

 */

