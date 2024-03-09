/*
 * @lc app=leetcode.cn id=2386 lang=csharp
 * @lcpr version=30118
 *
 * [2386] 找出数组的第 K 大和
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    int cnt;

    public long KSum(int[] nums, int k)
    {
        int n = nums.Length;
        long total = 0, total2 = 0;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] >= 0)
            {
                total += nums[i];
            }
            else
            {
                nums[i] = -nums[i];
            }
            total2 += Math.Abs(nums[i]);
        }
        Array.Sort(nums);

        long left = 0, right = total2;
        while (left <= right)
        {
            long mid = (left + right) / 2;
            cnt = 0;
            DFS(nums, k, n, 0, 0, mid);
            if (cnt >= k - 1)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return total - left;
    }

    public void DFS(int[] nums, int k, int n, int i, long t, long limit)
    {
        if (i == n || cnt >= k - 1 || t + nums[i] > limit)
        {
            return;
        }
        cnt++;
        DFS(nums, k, n, i + 1, t + nums[i], limit);
        DFS(nums, k, n, i + 1, t, limit);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,4,-2]\n5\n
// @lcpr case=end

// @lcpr case=start
// [1,-2,3,4,-10,12]\n16\n
// @lcpr case=end

 */

