/*
 * @lc app=leetcode.cn id=216 lang=csharp
 * @lcpr version=30122
 *
 * [216] 组合总和 III
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class Solution
{
    const int MAX = 9;
    IList<IList<int>> combinations = new List<IList<int>>();
    IList<int> temp = new List<int>();

    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        Backtrack(1, k, n);
        return combinations;
    }

    public void Backtrack(int num, int remainCount, int remainSum)
    {
        //达到退出条件
        if (remainCount == 0)
        {
            if (remainSum == 0)
            {
                combinations.Add(new List<int>(temp));
            }
        }
        //不满足退出条件
        else
        {
            //遍历尝试每一个下一位数的组合
            for (int i = num; i <= MAX && i <= remainSum; i++)
            {
                temp.Add(i);
                Backtrack(i + 1, remainCount - 1, remainSum - i);
                //清理尝试所选的数字，等待下一次尝试
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// 3\n7\n
// @lcpr case=end

// @lcpr case=start
// 3\n9\n
// @lcpr case=end

// @lcpr case=start
// 4\n1\n
// @lcpr case=end

 */

