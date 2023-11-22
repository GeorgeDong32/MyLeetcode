/*
 * @lc app=leetcode.cn id=705 lang=csharp
 *
 * [705] 设计哈希集合
 */

// @lc code=start
using System.Security.Cryptography;

public class MyHashSet
{
    private bool[] info;
    public MyHashSet()
    {
        info = new bool[1000001];
        Array.Fill(info, false);
    }

    public void Add(int key)
    {
        info[key] = true;
    }

    public void Remove(int key)
    {
        info[key] = false;
    }

    public bool Contains(int key)
    {
        return info[key];
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

