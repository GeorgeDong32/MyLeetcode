/*Q118*/

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        if (numRows == 0)
            return null;
        if (numRows == 1)
            return new List<IList<int>> { new List<int> { 1 } };
        else
        {
            var result = new List<IList<int>> { new List<int> { 1 } };
            for (int i = 1; i < numRows; i++)
            {
                var temp = new List<int> { 1 };
                for (int j = 1; j < i; j++)
                {
                    temp.Add(result[i - 1][j - 1] + result[i - 1][j]);
                }
                temp.Add(1);
                result.Add(temp);
            }
            return result;
        }
    }
}