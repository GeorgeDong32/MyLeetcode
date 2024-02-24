/*
 * @lc app=leetcode.cn id=1869 lang=csharp
 * @lcpr version=30117
 *
 * [1869] 哪种连续子字符串更长
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckZeroOnes(string s)
    {
        int longestOnes = 0, longestZeros = 0;
        int currentOnes = 0, currentZeros = 0;
        foreach (char c in s)
        {
            if (c == '1')
            {
                currentOnes++;
                longestOnes = Math.Max(longestOnes, currentOnes);
                currentZeros = 0;
            }
            else
            {
                currentZeros++;
                longestZeros = Math.Max(longestZeros, currentZeros);
                currentOnes = 0;
            }
        }
        return longestOnes > longestZeros;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "1101"\n
// @lcpr case=end

// @lcpr case=start
// "111000"\n
// @lcpr case=end

// @lcpr case=start
// "110100010"\n
// @lcpr case=end

 */

