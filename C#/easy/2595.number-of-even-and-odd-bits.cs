/*
 * @lc app=leetcode.cn id=2595 lang=csharp
 * @lcpr version=30122
 *
 * [2595] 奇偶位数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] EvenOddBit(int n)
    {
        int[] answer = new int[2];
        int index = 0;
        while (n != 0)
        {
            answer[index % 2] += n % 2;
            n /= 2;
            index++;
        }
        return answer;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 17\n
// @lcpr case=end

// @lcpr case=start
// 2\n
// @lcpr case=end

 */

