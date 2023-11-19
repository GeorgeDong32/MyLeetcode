/*
 * @lc app=leetcode.cn id=680 lang=csharp
 *
 * [680] 验证回文串 II
 */

// @lc code=start
public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int low = 0, high = s.Length - 1;
        while (low < high)
        {
            if (s[low] == s[high])
            {
                ++low;
                --high;
            }
            else
            {
                return ValidPalindrome(s, low, high - 1) || ValidPalindrome(s, low + 1, high);
            }
        }
        return true;
    }

    public bool ValidPalindrome(string s, int left, int right)
    {
        for (int i = left, j = right; i < j; ++i, --j)
        {
            if (s[i] != s[j])
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

