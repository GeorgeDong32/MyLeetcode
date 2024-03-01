/*
 * @lc app=leetcode.cn id=1893 lang=csharp
 * @lcpr version=30117
 *
 * [1893] 检查是否区域内所有整数都被覆盖
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsCovered(int[][] ranges, int left, int right)
    {
        int[] diff = new int[52];
        foreach (int[] range in ranges)
        {
            diff[range[0]]++;
            diff[range[1] + 1]--;
        }
        int sum = 0;
        for (int i = 1; i <= 50; i++)
        {
            sum += diff[i];
            if (sum <= 0 && i >= left && i <= right)
                return false;
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,2],[3,4],[5,6]]\n2\n5\n
// @lcpr case=end

// @lcpr case=start
// [[1,10],[10,20]]\n21\n21\n
// @lcpr case=end

 */

