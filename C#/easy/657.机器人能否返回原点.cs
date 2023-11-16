/*
 * @lc app=leetcode.cn id=657 lang=csharp
 *
 * [657] 机器人能否返回原点
 */

// @lc code=start
public class Solution
{
    public bool JudgeCircle(string moves)
    {
        var vert = 0; var hori = 0;
        foreach (var c in moves)
        {
            switch (c)
            {
                case 'U':
                    vert++; break;
                case 'D':
                    vert--; break;
                case 'L':
                    hori++; break;
                case 'R':
                    hori--; break;
                default:
                    break;
            }
        }
        return vert == 0 && hori == 0;
    }
}
// @lc code=end

