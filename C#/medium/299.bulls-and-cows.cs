/*
 * @lc app=leetcode.cn id=299 lang=csharp
 * @lcpr version=30119
 *
 * [299] 猜数字游戏
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public string GetHint(string secret, string guess)
    {
        int bulls = 0, cows = 0;
        int[] numbers = new int[10];
        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i]) bulls++;
            else
            {
                if (numbers[secret[i] - '0']++ < 0) cows++;
                if (numbers[guess[i] - '0']-- > 0) cows++;
            }
        }
        return bulls + "A" + cows + "B";
    }
}
// @lc code=end



/*
// @lcpr case=start
// "1807"\n"7810"\n
// @lcpr case=end

// @lcpr case=start
// "1123"\n"0111"\n
// @lcpr case=end

 */

