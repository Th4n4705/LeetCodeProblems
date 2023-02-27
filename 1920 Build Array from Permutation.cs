public class Solution {
    public int[] BuildArray(int[] nums) {
        List<int> arr = new();
        for (int i = 0; i < nums.Length; i++)
            arr.Add(nums[nums[i]]);
        return arr.ToArray();
    }
}