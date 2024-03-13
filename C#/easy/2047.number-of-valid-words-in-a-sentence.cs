/*
 * @lc app=leetcode.cn id=2047 lang=csharp
 * @lcpr version=30119
 *
 * [2047] 句子中的有效单词数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountValidWords(string sentence)
    {
        var ans = 0;
        var tokens = sentence.Split();
        tokens = tokens.Where(t => !string.IsNullOrWhiteSpace(t)).ToArray();
        foreach (var token in tokens)
        {
            bool hasDash = false, hasSymbol = false, legal = true;
            for (int i = 0; i < token.Length; i++)
            {
                if (char.IsDigit(token[i])) { legal = false; break; }
                if (token[i] == '-')
                {
                    if (i == 0 || i == token.Length - 1 || hasDash || !char.IsLower(token[i - 1]) || !char.IsLower(token[i + 1])) { legal = false; break; }
                    hasDash = true;
                }
                if (token[i] == '!' || token[i] == ',' || token[i] == '.')
                {
                    if (hasSymbol || i != token.Length - 1) { legal = false; break; }
                    hasSymbol = true;
                }
            }
            if (legal) ans++;
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "cat and  dog"\n
// @lcpr case=end

// @lcpr case=start
// "!this  1-s b8d!"\n
// @lcpr case=end

// @lcpr case=start
// "alice and  bob are playing stone-game10"\n
// @lcpr case=end

 */

