public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        List<double> maxList = new List<double>();
        double max = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i + k > nums.Length)
                break;
            else if (i == 0)
            {
                for (int j = i; j < i + k; j++)
                {
                    if (j < nums.Length)
                        max += (double)nums[j];
                }
            }
            else
                max = max - nums[i - 1] + nums[i + k - 1];
            maxList.Add(max);
        }

        max = maxList[0];

        for (int i = 0; i < maxList.Count; i++)
            max = Math.Max(maxList[i], max);


        return Convert.ToDouble(max / k);
    }
}