public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        List<int> ls = new();
        for (int i = 0; i < nums.Length; i++)
            ls.Insert(index[i], nums[i]);
        return ls.ToArray();
    }
}