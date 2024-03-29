/*
 * @lc app=leetcode.cn id=2325 lang=csharp
 * @lcpr version=30121
 *
 * [2325] 解密消息
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string DecodeMessage(string key, string message)
    {
        var dict = new Dictionary<char, int>();
        var dicc = 0;
        foreach (var c in key)
        {
            if (c != ' ')
            {
                if (dict.TryAdd(c, dicc))
                    dicc++;
            }
            if (dict.Count >= 26)
                break;
        }
        var sb = new StringBuilder();
        foreach (var c in message)
        {
            if (c != ' ')
                sb.Append((char)(dict[c] + 'a'));
            else
                sb.Append(' ');
        }
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "the quick brown fox jumps over the lazy dog"\n"vkbs bs t suepuv"\n
// @lcpr case=end

// @lcpr case=start
// "eljuxhpwnyrdgtqkviszcfmabo"\n"zwx hnfx lqantp mnoeius ycgk vcnjrdb"\n
// @lcpr case=end

 */

