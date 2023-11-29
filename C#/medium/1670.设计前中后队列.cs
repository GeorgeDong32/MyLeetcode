/*
 * @lc app=leetcode.cn id=1670 lang=csharp
 *
 * [1670] 设计前中后队列
 */

// @lc code=start
public class FrontMiddleBackQueue
{

    private List<int> ints;
    public FrontMiddleBackQueue()
    {
        ints = new();
    }

    public void PushFront(int val)
    {
        ints.Insert(0, val);
    }

    public void PushMiddle(int val)
    {
        ints.Insert(ints.Count / 2, val);
    }

    public void PushBack(int val)
    {
        ints.Add(val);
    }

    public int PopFront()
    {
        if (ints.Count == 0)
            return -1;
        var temp = ints[0];
        ints.RemoveAt(0);
        return temp;
    }

    public int PopMiddle()
    {
        if (ints.Count == 0)
            return -1;
        var index = ints.Count % 2 == 0 ? ints.Count / 2 - 1 : ints.Count / 2;
        var temp = ints[index];
        ints.RemoveAt(index);
        return temp;
    }

    public int PopBack()
    {
        if (ints.Count == 0)
            return -1;
        var temp = ints.Last();
        ints.RemoveAt(ints.Count - 1);
        return temp;
    }
}

/**
 * Your FrontMiddleBackQueue object will be instantiated and called as such:
 * FrontMiddleBackQueue obj = new FrontMiddleBackQueue();
 * obj.PushFront(val);
 * obj.PushMiddle(val);
 * obj.PushBack(val);
 * int param_4 = obj.PopFront();
 * int param_5 = obj.PopMiddle();
 * int param_6 = obj.PopBack();
 */
// @lc code=end

