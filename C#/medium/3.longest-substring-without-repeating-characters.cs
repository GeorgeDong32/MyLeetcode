/*
 * @lc app=leetcode.cn id=3 lang=csharp
 * @lcpr version=30122
 *
 * [3] 无重复字符的最长子串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<char>();
        var maxLength = 0;
        int start = 0, end = 0;
        var length = s.Length;
        while (end < length)
        {
            char c = s[end];
            while (start < end && set.Contains(c))
            {
                set.Remove(s[start]);
                start++;
            }
            set.Add(c);
            maxLength = Math.Max(maxLength, end - start + 1);
            end++;
        }
        return maxLength;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abcabcbb"\n
// @lcpr case=end

// @lcpr case=start
// "bbbbb"\n
// @lcpr case=end

// @lcpr case=start
// "pwwkew"\n
// @lcpr case=end

 */

