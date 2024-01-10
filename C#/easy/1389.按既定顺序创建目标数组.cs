/*
 * @lc app=leetcode.cn id=1389 lang=csharp
 *
 * [1389] 按既定顺序创建目标数组
 */

// @lc code=start
public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            list.Insert(index[i], nums[i]);
        }
        return list.ToArray();
    }
}
// @lc code=end

