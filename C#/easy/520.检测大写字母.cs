/*
 * @lc app=leetcode.cn id=520 lang=csharp
 *
 * [520] 检测大写字母
 */

// @lc code=start
public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        var up = word.ToUpper();
        var low = word.ToLower();
        if (word == up || word == low)
            return true;
        else
            return word.Substring(1) == low.Substring(1);
    }
}
// @lc code=end

