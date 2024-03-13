/*
 * @lc app=leetcode.cn id=2864 lang=csharp
 * @lcpr version=30119
 *
 * [2864] 最大二进制奇数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        var one = s.Count(x => x == '1');
        var n = s.Length;
        var sb = new StringBuilder();
        for (var i = 0; i < one - 1; i++)
        {
            sb.Append('1');
        }
        for (var i = 0; i < n - one; i++)
        {
            sb.Append('0');
        }
        sb.Append('1');
        return sb.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "010"\n
// @lcpr case=end

// @lcpr case=start
// "0101"\n
// @lcpr case=end

 */

