/*Q119*/

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var result = new List<int>();
        result.Add(1);
        for (var i = 1; i < rowIndex + 1; i++)
        {
            result.Add((int)(1L * result[i - 1] * (rowIndex - i + 1) / i));
        }
        return result;
    }
}