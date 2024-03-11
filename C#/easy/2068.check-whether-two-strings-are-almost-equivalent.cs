/*
 * @lc app=leetcode.cn id=2068 lang=csharp
 * @lcpr version=30119
 *
 * [2068] 检查两个字符串是否几乎相等
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckAlmostEquivalent(string word1, string word2)
    {
        var count = new int[26];
        for (var i = 0; i < word1.Length; i++)
        {
            count[word1[i] - 'a']++;
            count[word2[i] - 'a']--;
        }
        return count.All(c => -3 <= c && c <= 3);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "aaaa"\n"bccb"\n
// @lcpr case=end

// @lcpr case=start
// "abcdeef"\n"abaaacc"\n
// @lcpr case=end

// @lcpr case=start
// "cccddabba"\n"babababab"\n
// @lcpr case=end

 */

