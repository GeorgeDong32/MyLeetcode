/*
 * @lc app=leetcode.cn id=804 lang=csharp
 *
 * [804] 唯一摩尔斯密码词
 */

// @lc code=start
using System.Text;

public class Solution
{
    public static string[] MORSE = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                                      "....", "..", ".---", "-.-", ".-..", "--", "-.",
                                      "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                                      "...-", ".--", "-..-", "-.--", "--.." };
    public int UniqueMorseRepresentations(string[] words)
    {
        ISet<string> seen = new HashSet<string>();
        foreach (string word in words)
        {
            StringBuilder code = new StringBuilder();
            foreach (char c in word)
            {
                code.Append(MORSE[c - 'a']);
            }
            seen.Add(code.ToString());
        }
        return seen.Count;
    }
}
// @lc code=end

