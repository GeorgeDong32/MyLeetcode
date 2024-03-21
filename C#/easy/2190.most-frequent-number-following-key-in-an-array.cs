/*
 * @lc app=leetcode.cn id=2190 lang=csharp
 * @lcpr version=30119
 *
 * [2190] 数组中紧跟 key 之后出现最频繁的数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MostFrequent(int[] nums, int key)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == key)
            {
                if (dict.ContainsKey(nums[i + 1]))
                {
                    dict[nums[i + 1]]++;
                }
                else
                {
                    dict[nums[i + 1]] = 1;
                }
            }
        }

        int maxCount = 0;
        int maxNum = 0;
        foreach (var pair in dict)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                maxNum = pair.Key;
            }
        }

        return maxNum;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,100,200,1,100]\n1\n
// @lcpr case=end

// @lcpr case=start
// [2,2,2,2,3]\n2\n
// @lcpr case=end

 */

