/*
 * @lc app=leetcode.cn id=1346 lang=csharp
 *
 * [1346] 检查整数及其两倍数是否存在
 */

// @lc code=start
public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        return arr.Where((x, index_x) => Array.IndexOf(arr.Where((z, index_z) => index_z != index_x).ToArray(), x * 2) != -1).Any();
    }
}
// @lc code=end

