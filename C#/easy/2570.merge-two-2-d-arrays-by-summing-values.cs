/*
 * @lc app=leetcode.cn id=2570 lang=csharp
 * @lcpr version=30122
 *
 * [2570] 合并两个二维数组 - 求和法
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        IList<int[]> mergedList = new List<int[]>();
        int m = nums1.Length, n = nums2.Length;
        int index1 = 0, index2 = 0;
        while (index1 < m && index2 < n)
        {
            int id1 = nums1[index1][0], val1 = nums1[index1][1];
            int id2 = nums2[index2][0], val2 = nums2[index2][1];
            if (id1 < id2)
            {
                mergedList.Add(new int[] { id1, val1 });
                index1++;
            }
            else if (id1 > id2)
            {
                mergedList.Add(new int[] { id2, val2 });
                index2++;
            }
            else
            {
                mergedList.Add(new int[] { id1, val1 + val2 });
                index1++;
                index2++;
            }
        }
        while (index1 < m)
        {
            int id = nums1[index1][0], val = nums1[index1][1];
            mergedList.Add(new int[] { id, val });
            index1++;
        }
        while (index2 < n)
        {
            int id = nums2[index2][0], val = nums2[index2][1];
            mergedList.Add(new int[] { id, val });
            index2++;
        }
        return mergedList.ToArray();
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,2],[2,3],[4,5]]\n[[1,4],[3,2],[4,1]]\n
// @lcpr case=end

// @lcpr case=start
// [[2,4],[3,6],[5,5]]\n[[1,3],[4,3]]\n
// @lcpr case=end

 */

