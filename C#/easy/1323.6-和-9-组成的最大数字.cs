/*
 * @lc app=leetcode.cn id=1323 lang=csharp
 *
 * [1323] 6 和 9 组成的最大数字
 */

// @lc code=start
public class Solution
{
    public int Maximum69Number(int num)
    {
        var ns = num.ToString();
        var index = ns.IndexOf("6");
        if (index == -1)
            return num;
        ns = ns.Remove(index, 1);
        ns = ns.Insert(index, "9");
        return Convert.ToInt32(ns);
    }
}
// @lc code=end

