/*
 * @lc app=leetcode.cn id=387 lang=csharp
 *
 * [387] 字符串中的第一个唯一字符
 */

// @lc code=start
public class Solution
{
    public int FirstUniqChar(string s)
    {
        int[] count = new int[26];
        foreach (char c in s)
        {
            // 将字符转化成数字
            count[c - 'a']++;
        }
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (count[c - 'a'] == 1)
            {
                // 第一个出现一次的字符
                return i;
            }
        }
        return -1;
    }
}
// @lc code=end

