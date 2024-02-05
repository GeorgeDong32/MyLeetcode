/*
 * @lc app=leetcode.cn id=1656 lang=csharp
 *
 * [1656] 设计有序流
 */

// @lc code=start
public class OrderedStream
{
    private string[] stream;
    private int ptr;

    public OrderedStream(int n)
    {
        stream = new string[n];
        ptr = 0;
    }

    public IList<string> Insert(int idKey, string value)
    {
        stream[idKey - 1] = value;
        List<string> result = new List<string>();
        while (ptr < stream.Length && stream[ptr] != null)
        {
            result.Add(stream[ptr]);
            ptr++;
        }
        return result;
    }
}
/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */
// @lc code=end

