/*
 * @lc app=leetcode.cn id=717 lang=csharp
 *
 * [717] 1 比特与 2 比特字符
 */

// @lc code=start
public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        var i = 0;
        while (i < bits.Length - 1)
        {
            i += bits[i] + 1;
        }
        return i == bits.Length - 1;
    }
}
// @lc code=end

