/*
 * @lc app=leetcode.cn id=1629 lang=csharp
 *
 * [1629] 按键持续时间最长的键
 */

// @lc code=start
public class Solution
{
    public char SlowestKey(int[] releaseTimes, string keysPressed)
    {
        var kv = new Dictionary<char, int>();
        kv.Add(keysPressed[0], releaseTimes[0]);
        for (var i = 1; i < releaseTimes.Length; i++)
        {
            if (!kv.TryAdd(keysPressed[i], releaseTimes[i] - releaseTimes[i - 1]))
                kv[keysPressed[i]] = Math.Max(kv[keysPressed[i]], releaseTimes[i] - releaseTimes[i - 1]);
        }
        return kv.OrderBy(p => p.Value).ThenBy(p => p.Key).Last().Key;
    }
}
// @lc code=end

