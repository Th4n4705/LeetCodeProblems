public class Solution {
    public double MinimumAverage(int[] nums) {
        List<double> ls = new();
        Array.Sort(nums);
        int i = 0;
        int j = nums.Length - 1;
        while (i <= j)
        {
            ls.Add(((double)(nums[i] + nums[j]) / 2));
            i++;
            j--;
        }
        return ls.Min();
    }
}