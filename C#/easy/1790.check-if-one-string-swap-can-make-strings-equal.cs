/*
 * @lc app=leetcode.cn id=1790 lang=csharp
 * @lcpr version=30116
 *
 * [1790] 仅执行一次字符串交换能否使两个字符串相等
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        return StringDiff(s1, s2) <= 2 && StringCharDiff(s1, s2);
    }

    public int StringDiff(string s1, string s2)
    {
        var count = 0;
        for (var i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
                count++;
        }
        return count;
    }

    public bool StringCharDiff(string s1, string s2)
    {
        var diffChars1 = new List<char>();
        var diffChars2 = new List<char>();
        for (var i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                diffChars1.Add(s1[i]);
                diffChars2.Add(s2[i]);
            }
        }
        diffChars2.Reverse();
        return diffChars1.SequenceEqual(diffChars2);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "bank"\n"kanb"\n
// @lcpr case=end

// @lcpr case=start
// "attack"\n"defend"\n
// @lcpr case=end

// @lcpr case=start
// "kelb"\n"kelb"\n
// @lcpr case=end

// @lcpr case=start
// "abcd"\n"dcba"\n
// @lcpr case=end

 */

