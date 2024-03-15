/*
 * @lc app=leetcode.cn id=2099 lang=csharp
 * @lcpr version=30119
 *
 * [2099] 找到和最大的长度为 K 的子序列
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            pq.Enqueue([nums[i], i], nums[i]);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        int[][] numsIndices = new int[k][];
        for (int i = 0; i < k; i++)
        {
            numsIndices[i] = pq.Dequeue();
        }
        Array.Sort(numsIndices, (a, b) => a[1] - b[1]);
        int[] subsequence = new int[k];
        for (int i = 0; i < k; i++)
        {
            subsequence[i] = numsIndices[i][0];
        }
        return subsequence;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,1,3,3]\n2\n
// @lcpr case=end

// @lcpr case=start
// [-1,-2,3,4]\n3\n
// @lcpr case=end

// @lcpr case=start
// [3,4,3,3]\n2\n
// @lcpr case=end

 */

