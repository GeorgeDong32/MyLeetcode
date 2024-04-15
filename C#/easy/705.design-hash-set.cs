/*
 * @lc app=leetcode.cn id=705 lang=csharp
 * @lcpr version=30122
 *
 * [705] 设计哈希集合
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class MyHashSet
{
    private bool[] storage;
    public MyHashSet()
    {
        storage = new bool[1000001];
    }

    public void Add(int key)
    {
        storage[key] = true;
    }

    public void Remove(int key)
    {
        storage[key] = false;
    }

    public bool Contains(int key)
    {
        return storage[key] == true;
    }
}
/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
// @lc code=end



/*
// @lcpr case=start
// ["MyHashSet", "add", "add", "contains", "contains", "add", "contains", "remove", "contains"][[], [1], [2], [1], [3], [2], [2], [2], [2]]\n
// @lcpr case=end

 */

