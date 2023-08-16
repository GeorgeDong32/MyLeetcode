/*Q169*/
var sol = new Solution();

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var maj = nums[0];
        var count = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == maj)
            {
                count++;
            }
            else if (count == 0)
            {
                maj = nums[i];
            }
            else
            {
                count--;
            }
        }
        return maj;
    }
}