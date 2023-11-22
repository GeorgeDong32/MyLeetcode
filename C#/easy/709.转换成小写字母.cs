/*
 * @lc app=leetcode.cn id=709 lang=csharp
 *
 * [709] 转换成小写字母
 */

// @lc code=start
public class Solution
{
    public string ToLowerCase(string s)
    {
        String output = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
            {
                output += (char)(s[i] - 'A' + 'a');
            }
            else
                output += s[i];
        }
        return output;
    }
}
// @lc code=end

