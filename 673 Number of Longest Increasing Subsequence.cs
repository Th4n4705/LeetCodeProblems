public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        if (nums.Length == 0)
            return 0;
        int[] lengths = new int[nums.Length];
        int[] counts = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            lengths[i] = 1;
            counts[i] = 1;
        }
        int maxLength = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
                if (nums[i] > nums[j])
                {
                    if (lengths[j] + 1 > lengths[i])
                    {
                        lengths[i] = lengths[j] + 1;
                        counts[i] = counts[j];
                    }
                    else if (lengths[j] + 1 == lengths[i])
                        counts[i] += counts[j];
                }
                maxLength = Math.Max(maxLength, lengths[i]);
        }
        int ans = 0;
        for (int i = 0; i < nums.Length; i++)
            if (lengths[i] == maxLength)
                ans += counts[i];
        return ans;
    }
}