/*
 * @lc app=leetcode.cn id=6 lang=csharp
 * @lcpr version=30122
 *
 * [6] Z 字形变换
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        var rows = new StringBuilder[numRows];
        for (var i = 0; i < numRows; i++)
        {
            rows[i] = new StringBuilder();
        }
        int index = 0, dir = 1;
        for (int i = 0; i < s.Length; i++)
        {
            rows[index].Append(s[i]);
            index += dir;
            if (index == 0 || index == numRows - 1)
            {
                dir = -dir;
            }
        }
        var res = new StringBuilder();
        foreach (var row in rows)
        {
            res.Append(row);
        }
        return res.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "PAYPALISHIRING"\n3\n
// @lcpr case=end

// @lcpr case=start
// "PAYPALISHIRING"\n4\n
// @lcpr case=end

// @lcpr case=start
// "A"\n1\n
// @lcpr case=end

 */

