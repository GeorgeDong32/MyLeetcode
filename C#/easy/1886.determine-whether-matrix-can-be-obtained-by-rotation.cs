/*
 * @lc app=leetcode.cn id=1886 lang=csharp
 * @lcpr version=30117
 *
 * [1886] 判断矩阵经轮转后是否一致
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool FindRotation(int[][] mat, int[][] target)
    {
        for (int i = 0; i < 4; i++)
        {
            mat = Rotate(mat);
            if (IsEqual(mat, target))
            {
                return true;
            }
        }
        return false;
    }

    private int[][] Rotate(int[][] mat)
    {
        int n = mat.Length;
        int[][] newMat = new int[n][];
        for (int i = 0; i < n; i++)
        {
            newMat[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                newMat[i][j] = mat[n - j - 1][i];
            }
        }
        return newMat;
    }

    private bool IsEqual(int[][] mat1, int[][] mat2)
    {
        for (int i = 0; i < mat1.Length; i++)
        {
            for (int j = 0; j < mat1[i].Length; j++)
            {
                if (mat1[i][j] != mat2[i][j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[0,1],[1,0]]\n[[1,0],[0,1]]\n
// @lcpr case=end

// @lcpr case=start
// [[0,1],[1,1]]\n[[1,0],[0,1]]\n
// @lcpr case=end

// @lcpr case=start
// [[0,0,0],[0,1,0],[1,1,1]]\n[[1,1,1],[0,1,0],[0,0,0]]\n
// @lcpr case=end

 */

