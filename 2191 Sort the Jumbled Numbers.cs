public class Solution {
    public int[] SortJumbled(int[] mapping, int[] nums) {
        int[] arr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int a = nums[i];
            char[] c = a.ToString().ToCharArray();
            for (int j = 0; j < c.Length; j++)
                c[j] = (char)('0' + mapping[c[j] - '0']);
            arr[i] = int.Parse(c);
        }
        Array.Sort(arr, nums);
        return nums;
    }
}