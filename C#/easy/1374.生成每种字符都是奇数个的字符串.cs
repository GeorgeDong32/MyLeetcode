/*
 * @lc app=leetcode.cn id=1374 lang=csharp
 *
 * [1374] 生成每种字符都是奇数个的字符串
 */

// @lc code=start
public class Solution
{
    public string GenerateTheString(int n)
    {
        var ans = "";
        switch (n % 2)
        {
            case 0:
                while (n > 1)
                {
                    ans += "b";
                    n--;
                }
                while (n > 0)
                {
                    ans += "a";
                    n--;
                }
                break;
            case 1:
                while (n > 2)
                {
                    ans += "c";
                    n--;
                }
                while (n > 1)
                {
                    ans += "b";
                    n--;
                }
                while (n > 0)
                {
                    ans += "a";
                    n--;
                }
                break;
            default:
                break;
        }
        return ans;
    }
}
// @lc code=end

