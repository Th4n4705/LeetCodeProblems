public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if (nums == null || nums.Length == 0)
            return 0;
        
        double res = 0,
               sum = 0;
        int i = 0,
            j = 0;
        
        while (j < k)
            sum += (double)nums[j++];
        
        if (nums.Length <= k)
            return sum / (double)k;
        
        res = sum / (double)k;
        j--;
        
        do
        {
            sum -= (double)nums[i];
            
            i++;
            j++;
            
            sum += (double)nums[j];
            
            res = Math.Max(sum / (double)k, res);
        }
        while (j < nums.Length - 1);
        
        return res;
    }
}
