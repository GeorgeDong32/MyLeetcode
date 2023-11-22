/*
 * @lc app=leetcode.cn id=706 lang=csharp
 *
 * [706] 设计哈希映射
 */

// @lc code=start
public class MyHashMap
{
    private int[] values;
    public MyHashMap()
    {
        values = new int[1000001];
        Array.Fill(values, -1);
    }

    public void Put(int key, int value)
    {
        values[key] = value;
    }

    public int Get(int key)
    {
        return values[key];
    }

    public void Remove(int key)
    {
        values[key] = -1;
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

