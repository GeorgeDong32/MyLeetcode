/*
 * @lc app=leetcode.cn id=541 lang=csharp
 *
 * [541] 反转字符串 II
 */

// @lc code=start
public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] sChar = s.ToCharArray();
        int timeReverse = s.Length / (2 * k);
        int remainS = s.Length % (2 * k);
        for (int i = 0; i < timeReverse; i++)
        {
            Array.Reverse(sChar, i * 2 * k, k);
        }
        if (remainS < k)
        {
            Array.Reverse(sChar, timeReverse * 2 * k, remainS);
        }
        else
        {
            Array.Reverse(sChar, timeReverse * 2 * k, k);
        }
        return new string(sChar);
    }
}
// @lc code=end

