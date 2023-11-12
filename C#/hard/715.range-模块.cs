/*
 * @lc app=leetcode.cn id=715 lang=csharp
 *
 * [715] Range 模块
 */

// @lc code=start

public class RangeModule
{
    private List<int[]> Ranges = new();

    public void AddRange(int left, int right)
    {
        int i = 0, j = Ranges.Count - 1;
        if (j < 0 || Ranges[j][1] < left)
        {
            Ranges.Add(new int[] { left, right });
            return;
        }
        //第一个Ranges[i][1]>=left的项
        while (i < j)
        {
            var m = (i + j) >> 1;
            if (Ranges[m][1] >= left)
            {
                j = m;
            }
            else
            {
                i = m + 1;
            }
        }
        if (right < Ranges[i][0])
        {
            Ranges.Insert(i, new int[] { left, right });
            return;
        }
        Ranges[i][0] = Math.Min(Ranges[i][0], left);
        if (right > Ranges[i][1])
        {
            Ranges[i][1] = Math.Max(Ranges[i][1], right);
            Merge(i);
        }
    }

    void Merge(int k)
    {
        int n = Ranges.Count, j = k + 1;
        int right = Ranges[k][1];
        for (j = k + 1; j < n && right >= Ranges[j][0]; j++)
        {
            right = Math.Max(right, Ranges[j][1]);
        }
        if (j == k + 1) return;
        Ranges[k][1] = right;
        int i = k + 1;
        while (j < n)
        {
            Ranges[i++] = Ranges[j++];
        }
        while (--j >= i)
        {
            Ranges.RemoveAt(j);
        }
    }

    void RemoveAfter(int i, int right)
    {
        var n = Ranges.Count;
        int j = i;
        while (j < n && right > Ranges[j][0])
        {
            if (right < Ranges[j][1])
            {
                Ranges[j][0] = right;
                break;
            }
            j++;
        }
        if (i == j) return;
        while (j < n)
        {
            Ranges[i++] = Ranges[j++];
        }
        while (--j >= i)
        {
            Ranges.RemoveAt(j);
        }
    }

    public void RemoveRange(int left, int right)
    {
        int i = 0, j = Ranges.Count - 1;
        if (j < 0 || left >= Ranges[j][1] || right <= Ranges[0][0])
        {
            return;
        }
        while (i < j)
        {
            var m = (i + j) >> 1;
            if (left < Ranges[m][1])
            {
                j = m;
            }
            else
            {
                i = m + 1;
            }
        }
        if (right <= Ranges[i][0]) return;
        if (left <= Ranges[i][0])
        {
            if (right >= Ranges[i][1])
            {
                RemoveAfter(i, right);
            }
            else
            {
                Ranges[i][0] = right;
            }
        }
        else
        {
            if (right >= Ranges[i][1])
            {
                Ranges[i][1] = left;
                RemoveAfter(i + 1, right);
            }
            else
            {
                Ranges.Insert(i + 1, new int[] { right, Ranges[i][1] });
                Ranges[i][1] = left;
            }
        }

    }

    public bool QueryRange(int left, int right)
    {
        int i = 0, j = Ranges.Count - 1;
        if (j < 0 || left >= Ranges[j][1] || right <= Ranges[0][0])
        {
            return false;
        }
        while (i < j)
        {
            var m = (i + j) >> 1;
            if (Ranges[m][1] >= left)
            {
                j = m;
            }
            else
            {
                i = m + 1;
            }
        }
        return left >= Ranges[i][0] && right <= Ranges[i][1];
    }
}
// @lc code=end

