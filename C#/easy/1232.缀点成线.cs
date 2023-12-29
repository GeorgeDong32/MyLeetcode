/*
 * @lc app=leetcode.cn id=1232 lang=csharp
 *
 * [1232] 缀点成线
 */

// @lc code=start
public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        if (coordinates.Length == 2) return true;
        var xx = coordinates[1][0] - coordinates[0][0];
        var yy = coordinates[1][1] - coordinates[0][1];
        for (var i = 2; i < coordinates.Length; i++)
        {
            var ix = coordinates[i][0] - coordinates[0][0];
            var iy = coordinates[i][1] - coordinates[0][1];
            if (ix * yy - iy * xx != 0)
                return false;
        }
        return true;
    }
}
// @lc code=end

