public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> ans = new();
        for (int i = 0; i < nums.Length; i += 2)
        {
            int freq = nums[i];
            int value = nums[i + 1];
            for (int j = 0; j < freq; j++)
                ans.Add(value);
        }
        return ans.ToArray();
    }
}