/*
 * @lc app=leetcode.cn id=2671 lang=csharp
 * @lcpr version=30119
 *
 * [2671] 频率跟踪器
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
public class FrequencyTracker
{
    private IDictionary<int, int> numFrequencies;
    private IDictionary<int, ISet<int>> frequencyNums;

    public FrequencyTracker()
    {
        numFrequencies = new Dictionary<int, int>();
        frequencyNums = new Dictionary<int, ISet<int>>();
    }

    public void Add(int number)
    {
        int prevFrequency = numFrequencies.ContainsKey(number) ? numFrequencies[number] : 0;
        int frequency = prevFrequency + 1;
        if (numFrequencies.ContainsKey(number))
        {
            numFrequencies[number] = frequency;
        }
        else
        {
            numFrequencies.Add(number, frequency);
        }
        if (prevFrequency > 0)
        {
            frequencyNums[prevFrequency].Remove(number);
            if (frequencyNums[prevFrequency].Count == 0)
            {
                frequencyNums.Remove(prevFrequency);
            }
        }
        frequencyNums.TryAdd(frequency, new HashSet<int>());
        frequencyNums[frequency].Add(number);
    }

    public void DeleteOne(int number)
    {
        if (!numFrequencies.ContainsKey(number))
        {
            return;
        }
        int prevFrequency = numFrequencies[number];
        int frequency = prevFrequency - 1;
        if (frequency > 0)
        {
            numFrequencies[number] = frequency;
        }
        else
        {
            numFrequencies.Remove(number);
        }
        frequencyNums[prevFrequency].Remove(number);
        if (frequencyNums[prevFrequency].Count == 0)
        {
            frequencyNums.Remove(prevFrequency);
        }
        if (frequency > 0)
        {
            frequencyNums.TryAdd(frequency, new HashSet<int>());
            frequencyNums[frequency].Add(number);
        }
    }

    public bool HasFrequency(int frequency)
    {
        return frequencyNums.ContainsKey(frequency);
    }
}

/**
 * Your FrequencyTracker object will be instantiated and called as such:
 * FrequencyTracker obj = new FrequencyTracker();
 * obj.Add(number);
 * obj.DeleteOne(number);
 * bool param_3 = obj.HasFrequency(frequency);
 */
// @lc code=end



