public class Solution {
    public int FindKOr(int[] nums, int k) {
        int ans = 0;
        int digit = 1;
        bool continueLooping = true;
        while (continueLooping)
        {
            continueLooping = false;
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                    counter++;
                nums[i] /= 2;
                if (nums[i] > 0)
                    continueLooping = true;
            }
            if (counter >= k)
                ans += digit;
            digit *= 2;
        }
        return ans;
    }
}