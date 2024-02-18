/*
 * @lc app=leetcode.cn id=1812 lang=csharp
 * @lcpr version=30116
 *
 * [1812] 判断国际象棋棋盘中一个格子的颜色
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        var col = coordinates[0] - 'a';
        var row = coordinates[1] - '0';
        return (col + row) % 2 == 0;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "a1"\n
// @lcpr case=end

// @lcpr case=start
// "h3"\n
// @lcpr case=end

// @lcpr case=start
// "c7"\n
// @lcpr case=end

 */

