/*
 * @lc app=leetcode.cn id=2609 lang=csharp
 *
 * [2609] 最长平衡子字符串
 */

// @lc code=start
public class Solution
{
    public int FindTheLongestBalancedSubstring(string s)
    {
        var res = 0; var l0 = 0; var l1 = 0; var last = 0;
        foreach (var c in s)
        {
            switch (c)
            {
                case '0':
                    if (last == 1)
                    {
                        l0 = 0; l1 = 0;
                    }
                    l0++; last = 0;
                    break;
                case '1':
                    l1++; last = 1;
                    break;
            }
            if (l0 >= l1 & l1 > res)
                res = l1;
        }
        return res * 2;
    }
}
// @lc code=end

