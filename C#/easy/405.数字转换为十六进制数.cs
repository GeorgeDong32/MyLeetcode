/*
 * @lc app=leetcode.cn id=405 lang=csharp
 *
 * [405] 数字转换为十六进制数
 */

// @lc code=start
public class Solution
{
    public string ToHex(int num)
    {
        return num.ToString("X").ToLower();
    }
}
// @lc code=end

