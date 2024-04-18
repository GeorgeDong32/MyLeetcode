/*
 * @lc app=leetcode.cn id=2336 lang=csharp
 * @lcpr version=30122
 *
 * [2336] 无限集中的最小数字
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class SmallestInfiniteSet
{
    private HashSet<int> removed;
    public SmallestInfiniteSet()
    {
        removed = [];
    }

    public int PopSmallest()
    {
        for (var i = 1; i < 1001; i++)
        {
            if (!removed.Contains(i))
            {
                removed.Add(i);
                return i;
            }
        }
        return -1;
    }

    public void AddBack(int num)
    {
        if (removed.Contains(num))
            removed.Remove(num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
// @lc code=end



