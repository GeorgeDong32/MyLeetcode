/*
 * @lc app=leetcode.cn id=1710 lang=csharp
 * @lcpr version=30116
 *
 * [1710] 卡车上的最大单元数
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        boxTypes = boxTypes.OrderByDescending(box => box[1]).ToArray();
        var ans = 0;
        for (var i = 0; i < boxTypes.Length; i++)
        {
            if (truckSize <= 0)
                break;
            var boxam = boxTypes[i][0];
            var boxvol = boxTypes[i][1];
            if (truckSize >= boxam)
            {
                truckSize -= boxam;
                ans += boxam * boxvol;
            }
            else
            {
                ans += truckSize * boxvol;
                truckSize = 0;
            }
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[1,3],[2,2],[3,1]]\n4\n
// @lcpr case=end

// @lcpr case=start
// [[5,10],[2,5],[4,7],[3,9]]\n10\n
// @lcpr case=end

 */

