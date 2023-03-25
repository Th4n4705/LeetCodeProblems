public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        int k = nums.Length;
        int l = queries.Length;
        int[] ans = new int[l];
        Array.Sort(nums);
        int sum = 0;
        foreach (var n in nums)
            sum += n;
        for (int i = 0; i < l; i++)
        {
            int j = k - 1;
            int currentSum = sum;
            while (j >= 0 && currentSum > queries[i])
            {
                currentSum -= nums[j];
                j--;
            }
            ans[i] = j + 1;
        }
        return ans;
    }
}