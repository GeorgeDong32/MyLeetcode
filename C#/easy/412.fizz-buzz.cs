/*
 * @lc app=leetcode.cn id=412 lang=csharp
 *
 * [412] Fizz Buzz
 */

// @lc code=start
public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var ans = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
                ans.Add("FizzBuzz");
            else if (i % 3 == 0)
                ans.Add("Fizz");
            else if (i % 5 == 0)
                ans.Add("Buzz");
            else
                ans.Add($"{i}");
        }
        return ans;
    }
}
// @lc code=end

