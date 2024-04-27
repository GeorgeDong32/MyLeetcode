/*
 * @lc app=leetcode.cn id=649 lang=csharp
 * @lcpr version=30122
 *
 * [649] Dota2 参议院
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        var queue = new Queue<char>();
        var countr = 0; var countd = 0;
        var banr = 0; var band = 0;
        foreach (var c in senate)
        {
            queue.Enqueue(c);
            if (c == 'R')
                countr++;
            else
                countd++;
        }
        while (countr > 0 && countd > 0)
        {
            var s = queue.Dequeue();
            if (s == 'R')
            {
                if (banr > 0)
                    banr--;
                else
                {
                    countd--;
                    band++;
                    queue.Enqueue(s);
                }
            }
            else
            {
                if (band > 0)
                    band--;
                else
                {
                    countr--;
                    banr++;
                    queue.Enqueue(s);
                }
            }
        }
        return countr > 0 ? "Radiant" : "Dire";
    }
}
// @lc code=end



/*
// @lcpr case=start
// "RD"\n
// @lcpr case=end

// @lcpr case=start
// "RDD"\n
// @lcpr case=end

 */

