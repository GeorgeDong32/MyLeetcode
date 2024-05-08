/*
 * @lc app=leetcode.cn id=1652 lang=csharp
 * @lcpr version=30122
 *
 * [1652] 拆炸弹
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] Decrypt(int[] code, int k)
    {
        int n = code.Length;
        int[] ans = new int[n];
        if (k == 0)
        {
            return ans;
        }
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            if (k > 0)
            {
                for (int j = 1; j <= k; j++)
                {
                    sum += code[(i + j) % n];
                }
            }
            else
            {
                for (int j = k; j < 0; j++)
                {
                    sum += code[(i + j + n) % n];
                }
            }
            ans[i] = sum;
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,7,1,4]\n3\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4]\n0\n
// @lcpr case=end

// @lcpr case=start
// [2,4,9,3]\n-2\n
// @lcpr case=end

 */

