/*
 * @lc app=leetcode.cn id=860 lang=csharp
 *
 * [860] 柠檬水找零
 */

// @lc code=start
public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        int[] cash = new int[2];
        if (bills[0] == 10 || bills[0] == 20)
        {
            return false;
        }
        foreach (var bill in bills)
        {
            switch (bill)
            {
                case 5:
                    cash[0]++;
                    break;
                case 10:
                    cash[0]--;
                    cash[1]++;
                    break;
                case 20:
                    if (cash[1] > 0)
                    {
                        cash[1]--;
                        cash[0]--;
                    }
                    else
                    {
                        cash[0] -= 3;
                    }
                    break;
            }
            if (cash[0] < 0)
                return false;
        }
        return true;
    }
}
// @lc code=end

