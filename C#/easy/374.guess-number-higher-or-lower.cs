/*
 * @lc app=leetcode.cn id=374 lang=csharp
 * @lcpr version=30122
 *
 * [374] 猜数字大小
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int l = 1, r = n;
        while (l < r)
        {
            int mid = l + ((r - l) >> 1);
            if (guess(mid) > 0)
                l = mid + 1;
            else
                r = mid;
        }
        return l;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 10\n6\n
// @lcpr case=end

// @lcpr case=start
// 1\n1\n
// @lcpr case=end

// @lcpr case=start
// 2\n1\n
// @lcpr case=end

// @lcpr case=start
// 2\n2\n
// @lcpr case=end

 */

