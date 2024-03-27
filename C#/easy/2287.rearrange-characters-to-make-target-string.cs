/*
 * @lc app=leetcode.cn id=2287 lang=csharp
 * @lcpr version=30120
 *
 * [2287] 重排字符形成目标字符串
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int RearrangeCharacters(string s, string target)
    {
        var dict1 = new Dictionary<char, int>();
        var dict2 = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!dict1.TryAdd(c, 1))
                dict1[c]++;
        }
        foreach (var c in target)
        {
            if (!dict2.TryAdd(c, 1))
                dict2[c]++;
        }
        var res = 999999;
        foreach (var kv in dict2)
        {
            if (dict1.ContainsKey(kv.Key))
                res = Math.Min(res, dict1[kv.Key] / kv.Value);
            else
                res = 0;
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "ilovecodingonleetcode"\n"code"\n
// @lcpr case=end

// @lcpr case=start
// "abcba"\n"abc"\n
// @lcpr case=end

// @lcpr case=start
// "abbaccaddaeea"\n"aaaaa"\n
// @lcpr case=end

 */

