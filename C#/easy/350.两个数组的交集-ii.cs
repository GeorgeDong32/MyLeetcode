/*
 * @lc app=leetcode.cn id=350 lang=csharp
 *
 * [350] 两个数组的交集 II
 */

// @lc code=start
public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        IList<int> intersectionList = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        int length1 = nums1.Length, length2 = nums2.Length;
        int index1 = 0, index2 = 0;
        while (index1 < length1 && index2 < length2)
        {
            if (index1 < length1 && index2 < length2)
            {
                if (nums1[index1] == nums2[index2])
                {
                    intersectionList.Add(nums1[index1]);
                    index1++;
                    index2++;
                }
                else if (nums1[index1] < nums2[index2])
                {
                    index1++;
                }
                else
                {
                    index2++;
                }
            }
        }
        return intersectionList.ToArray();
    }
}
// @lc code=end

