/*
 * @lc app=leetcode.cn id=2037 lang=csharp
 * @lcpr version=30119
 *
 * [2037] 使每位学生都有座位的最少移动次数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);
        var moves = 0;
        for (var i = 0; i < seats.Length; i++)
        {
            moves += Math.Abs(students[i] - seats[i]);
        }
        return moves;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,1,5]\n[2,7,4]\n
// @lcpr case=end

// @lcpr case=start
// [4,1,5,9]\n[1,3,2,6]\n
// @lcpr case=end

// @lcpr case=start
// [2,2,6,6]\n[1,3,2,6]\n
// @lcpr case=end

 */

