/*
 * @lc app=leetcode.cn id=706 lang=csharp
 * @lcpr version=30122
 *
 * [706] 设计哈希映射
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class MyHashMap
{
    int[] storage;
    bool[] status;
    public MyHashMap()
    {
        storage = new int[1000001];
        status = new bool[1000001];
    }

    public void Put(int key, int value)
    {
        storage[key] = value;
        status[key] = true;
    }

    public int Get(int key)
    {
        return status[key] ? storage[key] : -1;
    }

    public void Remove(int key)
    {
        status[key] = false;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
// @lc code=end



/*
// @lcpr case=start
// ["MyHashMap", "put", "put", "get", "get", "put", "get", "remove", "get"][[], [1, 1], [2, 2], [1], [3], [2, 1], [2], [2], [2]]\n
// @lcpr case=end

 */

