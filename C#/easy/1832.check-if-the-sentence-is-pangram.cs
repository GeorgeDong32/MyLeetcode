/*
 * @lc app=leetcode.cn id=1832 lang=csharp
 * @lcpr version=30117
 *
 * [1832] 判断句子是否为全字母句
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        if (sentence.Length < 26)
            return false;
        var set = new HashSet<char>(sentence);
        return set.Count == 26;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "thequickbrownfoxjumpsoverthelazydog"\n
// @lcpr case=end

// @lcpr case=start
// "leetcode"\n
// @lcpr case=end

 */

