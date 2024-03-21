/*
 * @lc app=leetcode.cn id=2194 lang=csharp
 * @lcpr version=30119
 *
 * [2194] Excel 表中某个范围内的单元格
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
using System.Text;

public class Solution
{
    public IList<string> CellsInRange(string s)
    {
        var parts = s.Split(':');
        var start = parts[0];
        var end = parts[1];

        var startColumn = ColumnToNumber(start.Substring(0, 1));
        var startRow = int.Parse(start.Substring(1));
        var endColumn = ColumnToNumber(end.Substring(0, 1));
        var endRow = int.Parse(end.Substring(1));

        var result = new List<string>();
        for (int i = startColumn; i <= endColumn; i++)
        {
            for (int j = startRow; j <= endRow; j++)
            {
                result.Add(NumberToColumn(i) + j);
            }
        }

        return result;
    }

    private int ColumnToNumber(string column)
    {
        int number = 0;
        for (int i = 0; i < column.Length; i++)
        {
            number = number * 26 + (column[i] - 'A' + 1);
        }
        return number;
    }

    private string NumberToColumn(int number)
    {
        var column = new StringBuilder();
        while (number > 0)
        {
            number--;
            column.Insert(0, (char)('A' + number % 26));
            number /= 26;
        }
        return column.ToString();
    }
}
// @lc code=end



/*
// @lcpr case=start
// "K1:L2"\n
// @lcpr case=end

// @lcpr case=start
// "A1:F1"\n
// @lcpr case=end

 */

