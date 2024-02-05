/*
 * @lc app=leetcode.cn id=1640 lang=csharp
 *
 * [1640] 能否连接形成数组
 */

// @lc code=start
public class Solution
{
    public bool CanFormArray(int[] arr, int[][] pieces)
    {
        Dictionary<int, int[]> map = new Dictionary<int, int[]>();
        foreach (var piece in pieces)
        {
            map[piece[0]] = piece;
        }
        for (int i = 0; i < arr.Length;)
        {
            if (!map.ContainsKey(arr[i]))
            {
                return false;
            }
            var piece = map[arr[i]];
            foreach (var num in piece)
            {
                if (arr[i] != num)
                {
                    return false;
                }
                i++;
            }
        }
        return true;
    }
}
// @lc code=end

