public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        int counter1 = 0;
        int counter2 = 0;
        int j = nums.Length - 1;
        int k = nums[0];
        int l = nums[j];
        for (int i = 0; i <= j; i++)
        {
            if (nums[i] == k)
                counter1++;
            else if (nums[i] != k && counter1 == 1)
                return k;
            else
            {
                counter1 = 1;
                k = nums[i];
            }

            if (nums[j] == l)
                counter2++;
            else if (nums[j] != l && counter2 == 1)
                return l;
            else
            {
                counter2 = 1;
                l = nums[j];
            }
            j--;
        }
        return nums[j + 1];
    }
}