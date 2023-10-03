public class Solution {
    public int MinOperations(IList<int> nums, int k) {
        List<int> ls = new();
        for (int i = 1; i < k + 1; i++)
            ls.Add(i);
        int length = nums.Count - 1;
        while (ls.Count > 0 && length > -1)
        {
            ls.Remove(nums[length]);
            length--;
        }
        return nums.Count - length - 1;
    }
}