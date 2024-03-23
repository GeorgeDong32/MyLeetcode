/*
 * @lc app=leetcode.cn id=2220 lang=csharp
 * @lcpr version=30119
 *
 * [2220] 转换数字的最少位翻转次数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinBitFlips(int start, int goal)
    {
        int xor = start ^ goal;
        int count = 0;
        while (xor != 0)
        {
            count += xor & 1;
            xor >>= 1;
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 10\n7\n
// @lcpr case=end

// @lcpr case=start
// 3\n4\n
// @lcpr case=end

 */

