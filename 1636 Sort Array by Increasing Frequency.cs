public class Solution {
    public int[] FrequencySort(int[] nums) {
        Dictionary<int, int> dc = new();
        foreach (int n in nums)
            dc[n] = dc.GetValueOrDefault(n, 0) + 1;
        int i = 0;
        foreach (var (value, freq) in dc.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            for (int j = 0; j < freq; j++)
                nums[i++] = value;
        return nums;
    }
}