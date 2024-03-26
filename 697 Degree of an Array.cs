public class Solution {
    public int FindShortestSubArray(int[] nums) {
        Dictionary<int, int> counter = new();
        Dictionary<int, int[]> map = new();
        int ans = nums.Length;
        int max = 0;
        for (int i = 0; i < nums.Length; i ++)
        {
            counter.TryAdd(nums[i], 0);
            counter[nums[i]] += 1;
            max = Math.Max(max, counter[nums[i]]);
            if (map.ContainsKey(nums[i]))
                map[nums[i]][1] = i;
            else
                map[nums[i]] = new int[]{i, i};
        }
        foreach (int k in counter.Keys)
            if (counter[k] == max)
                ans = Math.Min(ans, map[k][1] - map[k][0] + 1);
        return ans;
    }
}