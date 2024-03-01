/*
 * @lc app=leetcode.cn id=1897 lang=csharp
 * @lcpr version=30117
 *
 * [1897] 重新分配字符使所有字符串都相等
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool MakeEqual(string[] words)
    {
        var lengths = words.Sum(word => word.Length);
        if (lengths % words.Length != 0)
            return false;
        var dict = new Dictionary<char, int>();
        foreach (var word in words)
        {
            foreach (var c in word)
            {
                if (!dict.TryAdd(c, 1))
                    dict[c]++;
            }
        }
        return dict.All(kv => kv.Value % words.Length == 0);
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["abc","aabc","bc"]\n
// @lcpr case=end

// @lcpr case=start
// ["ab","a"]\n
// @lcpr case=end

 */

