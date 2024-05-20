/*
 * @lc app=leetcode.cn id=1535 lang=csharp
 * @lcpr version=30202
 *
 * [1535] 找出数组游戏的赢家
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int GetWinner(int[] arr, int k)
    {
        int prev = Math.Max(arr[0], arr[1]);
        if (k == 1)
        {
            return prev;
        }
        int consecutive = 1;
        int maxNum = prev;
        int length = arr.Length;
        for (int i = 2; i < length; i++)
        {
            int curr = arr[i];
            if (prev > curr)
            {
                consecutive++;
                if (consecutive == k)
                {
                    return prev;
                }
            }
            else
            {
                prev = curr;
                consecutive = 1;
            }
            maxNum = Math.Max(maxNum, curr);
        }
        return maxNum;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,1,3,5,4,6,7]\n2\n
// @lcpr case=end

// @lcpr case=start
// [3,2,1]\n10\n
// @lcpr case=end

// @lcpr case=start
// [1,9,8,2,3,7,6,4,5]\n7\n
// @lcpr case=end

// @lcpr case=start
// [1,11,22,33,44,55,66,77,88,99]\n1000000000\n
// @lcpr case=end

 */

