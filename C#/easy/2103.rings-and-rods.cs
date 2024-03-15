/*
 * @lc app=leetcode.cn id=2103 lang=csharp
 * @lcpr version=30119
 *
 * [2103] 环和杆
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int CountPoints(string rings)
    {
        var r = new int[10];
        var g = new int[10];
        var b = new int[10];
        for (var i = 0; i < rings.Length; i += 2)
        {
            switch (rings[i])
            {
                case 'R':
                    r[rings[i + 1] - '0']++;
                    break;
                case 'G':
                    g[rings[i + 1] - '0']++;
                    break;
                case 'B':
                    b[rings[i + 1] - '0']++;
                    break;
            }
        }
        var count = 0;
        for (var i = 0; i < 10; i++)
        {
            if (r[i] > 0 && g[i] > 0 && b[i] > 0)
                count++;
        }
        return count;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "B0B6G0R6R0R6G9"\n
// @lcpr case=end

// @lcpr case=start
// "B0R0G0R9R0B0G0"\n
// @lcpr case=end

// @lcpr case=start
// "G4"\n
// @lcpr case=end

 */

