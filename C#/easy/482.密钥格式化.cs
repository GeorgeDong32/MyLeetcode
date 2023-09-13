/*
 * @lc app=leetcode.cn id=482 lang=csharp
 *
 * [482] 密钥格式化
 */

// @lc code=start
public class Solution
{
    public string LicenseKeyFormatting(string s, int k)
    {
        var res = s.ToUpper();
        res = res.Replace("-", "");
        var l = res.Length;
        for (var i = 1; i * k < l; i++)
        {
            res = res.Insert(l - i * k, "-");
        }
        return res;
    }
}
// @lc code=end

