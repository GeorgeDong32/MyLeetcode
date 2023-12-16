/*
 * @lc app=leetcode.cn id=999 lang=csharp
 *
 * [999] 可以被一步捕获的棋子数
 */

// @lc code=start
public class Solution
{
    public int NumRookCaptures(char[][] board)
    {
        int rookRow = -1, rookColumn = -1;
        int rows = board.Length, columns = board[0].Length;
        int totalSquares = rows * columns;
        for (int i = 0; i < totalSquares; i++)
        {
            int row = i / columns, column = i % columns;
            if (board[row][column] == 'R')
            {
                rookRow = row;
                rookColumn = column;
                break;
            }
        }
        int count = 0;
        int[][] directions = { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };
        foreach (int[] direction in directions)
        {
            int tempRow = rookRow + direction[0], tempColumn = rookColumn + direction[1];
            while (tempRow >= 0 && tempRow < rows && tempColumn >= 0 && tempColumn < columns)
            {
                if (board[tempRow][tempColumn] != '.')
                {
                    if (board[tempRow][tempColumn] == 'p')
                    {
                        count++;
                    }
                    break;
                }
                tempRow += direction[0];
                tempColumn += direction[1];
            }
        }
        return count;
    }
}
// @lc code=end

