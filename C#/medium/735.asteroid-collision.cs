/*
 * @lc app=leetcode.cn id=735 lang=csharp
 * @lcpr version=30122
 *
 * [735] 小行星碰撞
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();
        int length = asteroids.Length;
        for (int i = 0; i < length; i++)
        {
            int curr = asteroids[i];
            if (curr > 0)
            {
                stack.Push(curr);
            }
            else
            {
                bool flag = true;
                while (stack.Count > 0 && stack.Peek() > 0)
                {
                    int prev = stack.Peek();
                    if (-curr < prev)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        stack.Pop();
                        if (curr == -prev)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    stack.Push(curr);
                }
            }
        }
        int size = stack.Count;
        int[] remain = new int[size];
        for (int i = size - 1; i >= 0; i--)
        {
            remain[i] = stack.Pop();
        }
        return remain;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,10,-5]\n
// @lcpr case=end

// @lcpr case=start
// [8,-8]\n
// @lcpr case=end

// @lcpr case=start
// [10,2,-5]\n
// @lcpr case=end

 */

