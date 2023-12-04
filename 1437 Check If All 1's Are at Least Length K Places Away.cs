public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        for (int i = 0; i < nums.Length; i += k + 1)
        {
            int sum = 0;
            for (int j = i; j < i + k + 1; j++)
            {
                if (nums.Length <= j)
                    break;
                sum += nums[j];
            }
            if (sum > 1)
                return false;
        }
        return true;
    }
}