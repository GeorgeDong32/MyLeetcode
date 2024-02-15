/*
 * @lc app=leetcode.cn id=1758 lang=csharp
 * @lcpr version=30116
 *
 * [1758] 生成交替二进制字符串的最少操作数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinOperations(string s)
    {
        int count1 = 0, count2 = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] - '0' != i % 2)
            {
                count1++;
            }
            if (s[i] - '0' != (i + 1) % 2)
            {
                count2++;
            }
        }
        return Math.Min(count1, count2);
    }
}
// @lc code=end



/*
// @lcpr case=start
// "0100"\n
// @lcpr case=end

// @lcpr case=start
// "10"\n
// @lcpr case=end

// @lcpr case=start
// "1111"\n
// @lcpr case=end

 */

