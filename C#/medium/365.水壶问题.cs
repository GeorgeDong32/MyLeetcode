/*
 * @lc app=leetcode.cn id=365 lang=csharp
 *
 * [365] 水壶问题
 */

// @lc code=start
public class Solution
{
    public bool CanMeasureWater(int jug1Capacity, int jug2Capacity, int targetCapacity)
    {
        if (jug1Capacity + jug2Capacity < targetCapacity)
        {
            return false;
        }
        if (jug1Capacity == targetCapacity || jug2Capacity == targetCapacity || jug1Capacity + jug2Capacity == targetCapacity)
        {
            return true;
        }
        return targetCapacity % GCD(jug1Capacity, jug2Capacity) == 0;
    }

    private int GCD(int a, int b)
    {
        if (a == b)
        {
            return a;
        }
        if ((a & 1) == 0 && (b & 1) == 0)
        {
            return GCD(a >> 1, b >> 1) << 1;
        }
        else if ((a & 1) == 0)
        {
            return GCD(a >> 1, b);
        }
        else if ((b & 1) == 0)
        {
            return GCD(a, b >> 1);
        }
        else
        {
            return GCD(Math.Abs(a - b), Math.Min(a, b));
        }
    }
}
// @lc code=end

