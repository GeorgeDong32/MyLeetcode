/*
 * @lc app=leetcode.cn id=1309 lang=csharp
 *
 * [1309] 解码字母到整数映射
 */

// @lc code=start
public class Solution
{
    public string FreqAlphabets(string s)
    {
        string ans = "";
        char[] chars = s.ToCharArray();
        int index = 0, len = chars.Length;
        while (index < len)
        {
            if (index + 2 < len && chars[index + 2] == '#')
            {
                int i = Convert.ToInt16(Convert.ToString(chars[index++]) + Convert.ToString(chars[index++]));
                ans += (char)('a' + i - 1);
            }
            else ans += (char)((int)(chars[index] - '1') + 'a');
            index++;
        }
        return ans;
    }
}
// @lc code=end

