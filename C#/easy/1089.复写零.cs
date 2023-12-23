/*
 * @lc app=leetcode.cn id=1089 lang=csharp
 *
 * [1089] 复写零
 */

// @lc code=start
public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0, j = 0; j < length; i++, j++)
        {
            var current = arr[i] & 0x0F;
            if (current != 0)
            {
                arr[j] |= (current << 4);
            }
            else
            {
                j++;
            }
        }

        for (int i = 0; i < length; i++)
        {
            arr[i] >>= 4;
        }
    }
}
// @lc code=end

