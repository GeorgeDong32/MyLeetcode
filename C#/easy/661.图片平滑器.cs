/*
 * @lc app=leetcode.cn id=661 lang=csharp
 *
 * [661] 图片平滑器
 */

// @lc code=start
public class Solution
{
    public int[][] ImageSmoother(int[][] img)
    {
        int m = img.Length, n = img[0].Length;
        int[][] ret = new int[m][];
        for (int i = 0; i < m; i++)
        {
            ret[i] = new int[n];
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int num = 0, sum = 0;
                for (int x = i - 1; x <= i + 1; x++)
                {
                    for (int y = j - 1; y <= j + 1; y++)
                    {
                        if (x >= 0 && x < m && y >= 0 && y < n)
                        {
                            num++;
                            sum += img[x][y];
                        }
                    }
                }
                ret[i][j] = sum / num;
            }
        }
        return ret;
    }
}
// @lc code=end

