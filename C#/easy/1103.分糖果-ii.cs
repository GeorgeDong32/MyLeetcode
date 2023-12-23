/*
 * @lc app=leetcode.cn id=1103 lang=csharp
 *
 * [1103] 分糖果 II
 */

// @lc code=start
public class Solution
{
    public int[] DistributeCandies(int candies, int num_people)
    {
        var box = new int[num_people];
        var sc = 0; var cc = 1;
        while (candies >= cc)
        {
            box[sc] += cc;
            candies -= cc;
            sc++; cc++;
            if (sc >= num_people)
                sc = 0;
        }
        box[sc] += candies;
        return box;
    }
}
// @lc code=end

