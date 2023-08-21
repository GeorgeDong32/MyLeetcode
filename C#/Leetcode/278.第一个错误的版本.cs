/*
 * @lc app=leetcode.cn id=278 lang=csharp
 *
 * [278] 第一个错误的版本
 */

// @lc code=start
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        var start = 1; var end = n;
        while (start < end)
        { // 循环直至区间左右端点相同
            int mid = start + (end - start) / 2; // 防止计算时溢出
            if (IsBadVersion(mid))
            {
                end = mid; // 答案在区间 [left, mid] 中
            }
            else
            {
                start = mid + 1; // 答案在区间 [mid+1, right] 中
            }
        }
        return start;
    }
}
// @lc code=end

