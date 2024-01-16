/*
 * @lc app=leetcode.cn id=1417 lang=csharp
 *
 * [1417] 重新格式化字符串
 */

// @lc code=start
using System.Text;

public class Solution
{
    public string Reformat(string s)
    {
        StringBuilder letters = new StringBuilder();
        StringBuilder digits = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                letters.Append(c);
            }
            else
            {
                digits.Append(c);
            }
        }
        if (Math.Abs(letters.Length - digits.Length) > 1)
        {
            return "";
        }
        return letters.Length >= digits.Length ? Reformat(letters, digits) : Reformat(digits, letters);
    }

    public string Reformat(StringBuilder sb1, StringBuilder sb2)
    {
        StringBuilder Reformatted = new StringBuilder();
        int length = sb2.Length;
        for (int i = 0; i < length; i++)
        {
            Reformatted.Append(sb1[i]);
            Reformatted.Append(sb2[i]);
        }
        if (sb1.Length > length)
        {
            Reformatted.Append(sb1[length]);
        }
        return Reformatted.ToString();
    }
}
// @lc code=end

