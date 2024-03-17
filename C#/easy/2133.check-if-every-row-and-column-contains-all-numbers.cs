/*
 * @lc app=leetcode.cn id=2133 lang=csharp
 * @lcpr version=30119
 *
 * [2133] 检查是否每一行每一列都包含全部整数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool CheckValid(int[][] matrix)
    {
        int n = matrix.Length;
        for (int i = 0; i < n; i++)
        {
            if (matrix[i].Distinct().Count() != n || matrix.Select(row => row[i]).Distinct().Count() != n)
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,2,3],[3,1,2],[2,3,1]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,1,1],[1,2,3],[1,2,3]]\n
// @lcpr case=end

 */

