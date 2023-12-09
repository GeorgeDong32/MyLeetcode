/*
 * @lc app=leetcode.cn id=914 lang=csharp
 *
 * [914] 卡牌分组
 */

// @lc code=start
public class Solution
{
    public bool HasGroupsSizeX(int[] deck)
    {
        var dict = new Dictionary<int, int>();
        foreach (var n in deck)
        {
            var isadd = dict.TryAdd(n, 1);
            if (!isadd)
                dict[n]++;
        }
        var temp = dict.First().Value;
        foreach (var kv in dict)
        {
            temp = Gcd(temp, kv.Value);
        }
        return temp >= 2 ? true : false;
    }

    public static int Gcd(int a, int b)
    {
        return a % b == 0 ? b : Gcd(b, a % b);
    }
}
// @lc code=end

