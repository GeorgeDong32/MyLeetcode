/*
 * @lc app=leetcode.cn id=2553 lang=csharp
 * @lcpr version=30121
 *
 * [2553] 分割数组中数字的数位
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] SeparateDigits(int[] nums)
    {
        var res = new List<int>();
        var temp = new Stack<int>();
        foreach (var n in nums)
        {
            var tn = n;
            while (tn > 0)
            {
                temp.Push(tn % 10);
                tn /= 10;
            }
            while (temp.Count > 0)
            {
                res.Add(temp.Pop());
            }
        }
        return [.. res];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [13,25,83,77]\n
// @lcpr case=end

// @lcpr case=start
// [7,1,3,9]\n
// @lcpr case=end

 */

