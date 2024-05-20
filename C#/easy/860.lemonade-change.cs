/*
 * @lc app=leetcode.cn id=860 lang=csharp
 * @lcpr version=30202
 *
 * [860] 柠檬水找零
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        var five = 0; var ten = 0;
        foreach (var b in bills)
        {
            switch (b)
            {
                case 5:
                    five++;
                    break;
                case 10:
                    if (five <= 0)
                        return false;
                    five--;
                    ten++;
                    break;
                case 20:
                    if (five > 0 && ten > 0)
                    {
                        five--;
                        ten--;
                    }
                    else if (five >= 3)
                    {
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                default:
                    break;
            }
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,5,5,10,20]\n
// @lcpr case=end

// @lcpr case=start
// [5,5,10,10,20]\n
// @lcpr case=end

 */

