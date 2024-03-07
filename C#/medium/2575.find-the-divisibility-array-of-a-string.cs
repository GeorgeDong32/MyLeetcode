/*
 * @lc app=leetcode.cn id=2575 lang=csharp
 * @lcpr version=30118
 *
 * [2575] 找出字符串的可整除数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] DivisibilityArray(string word, int m)
    {
        var result = new int[word.Length];
        long value = 0;
        for (int i = 0; i < word.Length; i++)
        {
            int digit = word[i] - '0';
            value = (value * 10 + digit) % m;
            if (value == 0)
            {
                result[i] = 1;
            }
            else
            {
                result[i] = 0;
            }
        }
        return result;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "998244353"\n3\n
// @lcpr case=end

// @lcpr case=start
// "1010"\n10\n
// @lcpr case=end

 */

