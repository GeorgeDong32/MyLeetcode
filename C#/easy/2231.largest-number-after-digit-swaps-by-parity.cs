/*
 * @lc app=leetcode.cn id=2231 lang=csharp
 * @lcpr version=30119
 *
 * [2231] 按奇偶性交换后的最大数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int LargestInteger(int num)
    {
        PriorityQueue<int, int> odds = new PriorityQueue<int, int>();
        PriorityQueue<int, int> evens = new PriorityQueue<int, int>();
        int temp = num;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit % 2 != 0)
            {
                odds.Enqueue(digit, digit);
            }
            else
            {
                evens.Enqueue(digit, digit);
            }
            temp /= 10;
        }
        int largest = 0;
        temp = num;
        int unit = 1;
        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit % 2 != 0)
            {
                largest += odds.Dequeue() * unit;
            }
            else
            {
                largest += evens.Dequeue() * unit;
            }
            temp /= 10;
            unit *= 10;
        }
        return largest;
    }
}
// @lc code=end



/*
// @lcpr case=start
// 1234\n
// @lcpr case=end

// @lcpr case=start
// 65875\n
// @lcpr case=end

 */

