/*
 * @lc app=leetcode.cn id=765 lang=csharp
 *
 * [765] 情侣牵手
 */

// @lc code=start
public class Solution
{
    public int MinSwapsCouples(int[] row)
    {
        var count = 0;
        var positions = new int[row.Length];//元素在row中的位置
        for (int i = 0; i < row.Length - 1; i += 2)
        {
            var p = row[i] % 2 == 0 ? row[i] + 1 : row[i] - 1;
            if (row[i + 1] == p) continue;

            if (positions[p] > 0)
            {
                Swap(row, positions, i + 1, positions[p]);
                count++;
                continue;
            }

            for (int j = i + 2; j < row.Length; j++)
            {
                if (row[j] == p)
                {
                    Swap(row, positions, i + 1, j);
                    count++;
                }
                else
                    positions[row[j]] = j;
            }
        }
        return count;
    }

    private void Swap(int[] row, int[] positions, int a, int b)
    {
        var tmp = row[a];
        row[a] = row[b];
        row[b] = tmp;
        positions[tmp] = b;
    }
}
// @lc code=end

