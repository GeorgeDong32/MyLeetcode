/*
 * @lc app=leetcode.cn id=2022 lang=csharp
 * @lcpr version=30118
 *
 * [2022] 将一维数组转变成二维数组
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[][] Construct2DArray(int[] original, int m, int n)
    {

        if (original.Length != m * n)
        {
            return new int[0][]; ;
        }
        var result = new int[m][];
        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];
            for (var j = 0; j < n; j++)
            {
                result[i][j] = original[i * n + j];
            }
        }
        return result;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4]\n2\n2\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3]\n1\n3\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n1\n1\n
// @lcpr case=end

// @lcpr case=start
// [3]\n1\n2\n
// @lcpr case=end

 */

