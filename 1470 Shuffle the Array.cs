public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int j = n;
        List<int> newL = new();
        for (int i = 0; i < n; i++)
        {
            newL.Add(nums[i]);
            newL.Add(nums[j]);
            j++;
        }
        return newL.ToArray();
    }
}