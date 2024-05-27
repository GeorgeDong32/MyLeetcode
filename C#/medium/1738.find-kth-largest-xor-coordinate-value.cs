/*
 * @lc app=leetcode.cn id=1738 lang=csharp
 * @lcpr version=30202
 *
 * [1738] 找出第 K 大的异或坐标值
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int KthLargestValue(int[][] matrix, int k)
    {
        int m = matrix.Length, n = matrix[0].Length;
        int total = m * n;
        int[][] prefixXors = new int[m + 1][];
        for (int i = 0; i <= m; i++)
        {
            prefixXors[i] = new int[n + 1];
        }
        int[] allXors = new int[total];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                prefixXors[i + 1][j + 1] = prefixXors[i][j + 1] ^ prefixXors[i + 1][j] ^ prefixXors[i][j] ^ matrix[i][j];
                allXors[i * n + j] = prefixXors[i + 1][j + 1];
            }
        }
        Array.Sort(allXors);
        return allXors[total - k];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[5,2],[1,6]]\n1\n
// @lcpr case=end

// @lcpr case=start
// [[5,2],[1,6]]\n2\n
// @lcpr case=end

// @lcpr case=start
// [[5,2],[1,6]]\n3\n
// @lcpr case=end

// @lcpr case=start
// [[5,2],[1,6]]\n4\n
// @lcpr case=end

 */

