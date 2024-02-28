/*
 * @lc app=leetcode.cn id=1952 lang=csharp
 * @lcpr version=30117
 *
 * [1952] 三除数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool IsThree(int n)
    {
        var table = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        foreach (var x in table)
        {
            if (x * x == n)
                return true;
        }
        return false;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 2\n
// @lcpr case=end

// @lcpr case=start
// 4\n
// @lcpr case=end

 */

