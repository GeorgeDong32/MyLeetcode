/*
 * @lc app=leetcode.cn id=733 lang=csharp
 *
 * [733] 图像渲染
 */

// @lc code=start
public class Solution
{
    static int[][] dirs = { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };

    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int originalColor = image[sr][sc];
        if (originalColor == color)
        {
            return image;
        }
        int m = image.Length, n = image[0].Length;
        image[sr][sc] = color;
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { sr, sc });
        while (queue.Count > 0)
        {
            int[] cell = queue.Dequeue();
            int row = cell[0], col = cell[1];
            foreach (int[] dir in dirs)
            {
                int newRow = row + dir[0], newCol = col + dir[1];
                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && image[newRow][newCol] == originalColor)
                {
                    image[newRow][newCol] = color;
                    queue.Enqueue(new int[] { newRow, newCol });
                }
            }
        }
        return image;
    }
}
// @lc code=end

