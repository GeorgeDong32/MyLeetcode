/*
 * @lc app=leetcode.cn id=2391 lang=csharp
 * @lcpr version=30201
 *
 * [2391] 收集垃圾的最少总时间
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int GarbageCollection(string[] garbage, int[] travel)
    {
        var collectTime = 0;
        var travelTime = 0;
        var lastindex = new int[3];
        var gindex = 0;
        foreach (var g in garbage)
        {
            foreach (var c in g)
            {
                collectTime++;
                UpdateIndex(c, gindex, lastindex);
            }
            gindex++;
        }
        foreach (var i in lastindex)
        {
            for (var j = 0; j < i; j++)
            {
                travelTime += travel[j];
            }
        }
        return collectTime + travelTime;
    }

    public void UpdateIndex(char c, int currentIndex, int[] indexs)
    {
        switch (c)
        {
            case 'M':
                indexs[0] = currentIndex;
                break;
            case 'P':
                indexs[1] = currentIndex;
                break;
            case 'G':
                indexs[2] = currentIndex;
                break;
            default:
                break;
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// ["G","P","GP","GG"]\n[2,4,3]\n
// @lcpr case=end

// @lcpr case=start
// ["MMM","PGM","GP"]\n[3,10]\n
// @lcpr case=end

 */

