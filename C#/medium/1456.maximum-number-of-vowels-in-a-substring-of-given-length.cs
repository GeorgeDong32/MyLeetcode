/*
 * @lc app=leetcode.cn id=1456 lang=csharp
 * @lcpr version=30122
 *
 * [1456] 定长子串中元音的最大数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxVowels(string s, int k)
    {
        var count = 0;
        var length = s.Length;
        for (int i = 0; i < k; i++)
        {
            if (IsVowel(s[i]))
                count++;
        }
        int maxCount = count;
        for (int i = k; i < length; i++)
        {
            if (IsVowel(s[i - k]))
                count--;
            if (IsVowel(s[i]))
                count++;
            maxCount = Math.Max(maxCount, count);
        }
        return maxCount;
    }

    public static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abciiidef"\n3\n
// @lcpr case=end

// @lcpr case=start
// "aeiou"\n2\n
// @lcpr case=end

// @lcpr case=start
// "leetcode"\n3\n
// @lcpr case=end

// @lcpr case=start
// "rhythms"\n4\n
// @lcpr case=end

// @lcpr case=start
// "tryhard"\n4\n
// @lcpr case=end

 */

