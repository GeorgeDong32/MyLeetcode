/*
 * @lc app=leetcode.cn id=1700 lang=csharp
 * @lcpr version=30116
 *
 * [1700] 无法吃午餐的学生数量
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start

public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        int s1 = students.Sum();
        int s0 = students.Length - s1;
        for (int i = 0; i < sandwiches.Length; i++)
        {
            if (sandwiches[i] == 0 && s0 > 0)
                s0--;
            else if (sandwiches[i] == 1 && s1 > 0)
                s1--;
            else
                break;
        }
        return s0 + s1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,0,0]\n[0,1,0,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,0,0,1]\n[1,0,0,0,1,1]\n
// @lcpr case=end

 */

