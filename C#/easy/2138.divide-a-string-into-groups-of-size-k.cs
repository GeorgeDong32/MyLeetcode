/*
 * @lc app=leetcode.cn id=2138 lang=csharp
 * @lcpr version=30119
 *
 * [2138] 将字符串拆分为若干长度为 k 的组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        var res = new List<string>();
        var parts = s.Length % k == 0 ? s.Length / k : s.Length / k + 1;
        for (var i = 0; i < parts; i++)
        {
            var sb = new StringBuilder();
            for (var j = 0; j < k; j++)
            {
                if (i * k + j < s.Length)
                    sb.Append(s[i * k + j]);
                else
                    sb.Append(fill);
            }
            res.Add(sb.ToString());
        }
        return res.ToArray();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "abcdefghi"\n3\n"x"\n
// @lcpr case=end

// @lcpr case=start
// "abcdefghij"\n3\n"x"\n
// @lcpr case=end

 */

