/*
 * @lc app=leetcode.cn id=1925 lang=csharp
 * @lcpr version=30117
 *
 * [1925] 统计平方和三元组的数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountTriples(int n)
    {
        int count = 0;
        int nSquare = n * n;
        for (int a = 1; a <= n; a++)
        {
            int aSquare = a * a;
            for (int b = 1; aSquare + b * b <= nSquare; b++)
            {
                int cSquare = aSquare + b * b;
                int c = (int)Math.Sqrt(cSquare);
                if (c * c == cSquare)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 5\n
// @lcpr case=end

// @lcpr case=start
// 10\n
// @lcpr case=end

 */

