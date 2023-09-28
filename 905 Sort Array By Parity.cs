public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        List<int> even = new();
        List<int> odd = new();
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] % 2 != 0)
                odd.Add(nums[i]);
            else
                even.Add(nums[i]);
        return new List<int>(even.Concat(odd)).ToArray();
    }
}