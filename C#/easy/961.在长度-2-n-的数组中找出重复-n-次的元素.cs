/*
 * @lc app=leetcode.cn id=961 lang=csharp
 *
 * [961] 在长度 2N 的数组中找出重复 N 次的元素
 */

// @lc code=start
public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        var set = new HashSet<int>();
        var flag = true;
        foreach (var num in nums)
        {
            flag = set.Add(num);
            if (!flag)
            {
                return num;
            }
        }
        return -1;
    }
}
// @lc code=end

