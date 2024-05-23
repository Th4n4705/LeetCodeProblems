public class Solution {
    
    int sum = 0;
    public int BeautifulSubsets(int[] nums, int k) {
        Helper (nums, k, 0, new List<int>());
        return sum;
    }

    void Helper(int[] nums, int k, int start, List<int> subset)
    {
        if (subset.Count > 0)
            sum++;
        for (int i = start; i < nums.Length; i++)
        {
            bool flag = true;
            foreach (int n in subset)
                if (Math.Abs(n - nums[i]) == k)
                {
                    flag = false;
                    break;
                }
            if (flag)
            {
                subset.Add(nums[i]);
                Helper(nums, k, i + 1, subset);
                subset.Remove(nums[i]);
            }
        }
    }
}