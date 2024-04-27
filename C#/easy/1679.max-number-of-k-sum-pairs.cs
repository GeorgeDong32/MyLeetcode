/*
 * @lc app=leetcode.cn id=1679 lang=csharp
 * @lcpr version=30122
 *
 * [1679] K 和数对的最大数目
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int count = 0;
        foreach (int num in nums)
        {
            if (dict.ContainsKey(k - num) && dict[k - num] > 0)
            {
                count++;
                dict[k - num]--;
            }
            else
            {
                dict.TryAdd(num, 0);
                dict[num]++;
            }
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4]\n5\n
// @lcpr case=end

// @lcpr case=start
// [3,1,3,4,3]\n6\n
// @lcpr case=end

 */

