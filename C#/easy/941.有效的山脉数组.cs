/*
 * @lc app=leetcode.cn id=941 lang=csharp
 *
 * [941] 有效的山脉数组
 */

// @lc code=start
public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        var left = 0; var right = arr.Length - 1;
        while (left < right && arr[left] < arr[left + 1])
        {
            left++;
        }
        while (right > left && arr[right] < arr[right - 1])
        {
            right--;
        }
        return left == right && left != 0 && right != arr.Length - 1;
    }
}
// @lc code=end

