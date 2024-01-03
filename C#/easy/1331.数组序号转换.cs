/*
 * @lc app=leetcode.cn id=1331 lang=csharp
 *
 * [1331] 数组序号转换
 */

// @lc code=start
public class Solution
{
    public int[] ArrayRankTransform(int[] arr)
    {
        //转换成有序、无重复集合，再get索引号
        List<int> list = new List<int>(new HashSet<int>(arr));
        list.Sort();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = list.IndexOf(arr[i]) + 1;
        }
        return arr;
    }
}
// @lc code=end

