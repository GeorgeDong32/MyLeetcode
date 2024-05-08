/*
 * @lc app=leetcode.cn id=2079 lang=csharp
 * @lcpr version=30201
 *
 * [2079] 给植物浇水
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int WateringPlants(int[] plants, int capacity)
    {
        var ans = 0;
        var cw = capacity;
        for (var i = 0; i < plants.Length; i++)
        {
            if (plants[i] > cw)
            {
                ans += 2 * i;
                cw = capacity;
            }
            ans++;
            cw -= plants[i];
        }
        return ans;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,2,3,3]\n5\n
// @lcpr case=end

// @lcpr case=start
// [1,1,1,4,2,3]\n4\n
// @lcpr case=end

// @lcpr case=start
// [7,7,7,7,7,7,7]\n8\n
// @lcpr case=end

 */

