public class Solution {
    public int LongestArithSeqLength(int[] nums) {
        var dc = new Dictionary<int, Dictionary<int, int>>();
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            dc[i] = new Dictionary<int, int>();
            for (int j = 0; j < i; j++)
            {
                int diff = nums[j] - nums[i];
                dc[i][diff] = 1 + dc[j].GetValueOrDefault(diff, 0);
                max = Math.Max(max, dc[i][diff]);
            }
        }
        return ++max;
    }
}