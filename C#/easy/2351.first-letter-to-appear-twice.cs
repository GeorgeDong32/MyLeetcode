/*
 * @lc app=leetcode.cn id=2351 lang=csharp
 * @lcpr version=30121
 *
 * [2351] 第一个出现两次的字母
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public char RepeatedCharacter(string s)
    {
        var dict = new HashSet<char>();
        foreach (var c in s)
        {
            if (!dict.Add(c))
                return c;
        }
        return 'a';
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abccbaacz"\n
// @lcpr case=end

// @lcpr case=start
// "abcdd"\n
// @lcpr case=end

 */

