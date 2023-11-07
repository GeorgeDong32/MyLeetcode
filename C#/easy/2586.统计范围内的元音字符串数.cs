/*
 * @lc app=leetcode.cn id=2586 lang=csharp
 *
 * [2586] 统计范围内的元音字符串数
 */

// @lc code=start
public class Solution
{
    public static bool IsVowel(char c) => "aeiou".IndexOf(c) != -1;
    public int VowelStrings(string[] words, int left, int right)
    {
        var res = 0;
        for (var i = left; i <= right; i++)
        {
            if (IsVowel(words[i][0]) && IsVowel(words[i][words[i].Length - 1]))
                res++;
        }
        return res;
    }
}
// @lc code=end

