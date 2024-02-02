/*
 * @lc app=leetcode.cn id=1624 lang=csharp
 *
 * [1624] 两个相同字符之间的最长子字符串
 */

// @lc code=start
public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        int[] firstOccurrence = new int[26];
        for (int i = 0; i < 26; i++)
        {
            firstOccurrence[i] = -1;
        }
        int maxLength = -1;
        for (int i = 0; i < s.Length; i++)
        {
            int index = s[i] - 'a';
            if (firstOccurrence[index] == -1)
            {
                firstOccurrence[index] = i;
            }
            else
            {
                maxLength = Math.Max(maxLength, i - firstOccurrence[index] - 1);
            }
        }
        return maxLength;
    }
}
// @lc code=end

