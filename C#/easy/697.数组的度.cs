/*
 * @lc app=leetcode.cn id=697 lang=csharp
 *
 * [697] 数组的度
 */

// @lc code=start
public class Solution
{
    public int FindShortestSubArray(int[] nums)
    {
        var freqDict = new Dictionary<int, int>();
        var posDict = new Dictionary<int, int>();
        var maxFreq = 0;
        int shortLength = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (freqDict.ContainsKey(nums[i]))
            {
                freqDict[nums[i]]++;

                if (freqDict[nums[i]] > maxFreq)
                {
                    maxFreq = freqDict[nums[i]];

                    shortLength = i - posDict[nums[i]];
                }
                else if (freqDict[nums[i]] == maxFreq)
                {
                    var len = i - posDict[nums[i]];
                    if (shortLength > len)
                    {
                        shortLength = len;
                    }
                }
            }
            else
            {
                freqDict.Add(nums[i], 1);
                posDict.Add(nums[i], i);
            }
        }
        return shortLength + 1;
    }
}
// @lc code=end

