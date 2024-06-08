public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary<int, int> dc = new();
        int sum = 0;
        dc.Add(0, 0);
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            int res = sum % k;
            if (!dc.ContainsKey(res))
                dc[res] = i + 1;
            else if (dc[res] < i)
                return true;
        }
        return false;
    }
}