/*
 * @lc app=leetcode.cn id=682 lang=csharp
 *
 * [682] 棒球比赛
 */

// @lc code=start
public class Solution
{
    public int CalPoints(string[] ops)
    {
        int ret = 0;
        IList<int> points = new List<int>();
        foreach (string op in ops)
        {
            int n = points.Count;
            switch (op[0])
            {
                case '+':
                    ret += points[n - 1] + points[n - 2];
                    points.Add(points[n - 1] + points[n - 2]);
                    break;
                case 'D':
                    ret += 2 * points[n - 1];
                    points.Add(2 * points[n - 1]);
                    break;
                case 'C':
                    ret -= points[n - 1];
                    points.RemoveAt(n - 1);
                    break;
                default:
                    ret += int.Parse(op);
                    points.Add(int.Parse(op));
                    break;
            }
        }
        return ret;
    }
}
// @lc code=end

