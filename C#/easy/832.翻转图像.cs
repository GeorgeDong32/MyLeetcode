/*
 * @lc app=leetcode.cn id=832 lang=csharp
 *
 * [832] 翻转图像
 */

// @lc code=start
public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        var newimage = image;
        for (var i = 0; i < newimage.Length; i++)
        {
            var left = 0; var right = newimage[i].Length - 1;
            while (right > left)
            {
                newimage[i][left] ^= newimage[i][right];
                newimage[i][right] ^= newimage[i][left];
                newimage[i][left] ^= newimage[i][right];
                newimage[i][left] ^= 1; newimage[i][right] ^= 1;
                left++; right--;
            }
            if (right == left)
            {
                newimage[i][left] ^= 1;
            }
        }
        return newimage;
    }
}
// @lc code=end

