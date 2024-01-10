/*
 * @lc app=leetcode.cn id=2011 lang=csharp
 *
 * [2011] 执行操作后的变量值
 */

// @lc code=start
public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        var ans = 0;
        foreach (var op in operations)
        {
            switch (op)
            {
                case "X++":
                case "++X":
                    ans++;
                    break;
                case "X--":
                case "--X":
                    ans--;
                    break;
                default:
                    break;
            }
        }
        return ans;
    }
}
// @lc code=end

