public class Solution {
    public int MinStartValue(int[] nums) {
        int lowest = int.MaxValue;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            lowest = lowest <= sum ? lowest : sum;
        }
        return lowest <= 0 ? 1 - lowest : 1;
    }
}