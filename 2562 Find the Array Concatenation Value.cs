public class Solution {
    public long FindTheArrayConcVal(int[] nums) {
        int i = 0;
        int j = nums.Length - 1;
        long sum = 0;
        while (i <= j)
        {
            int n = 0;
            if (i != j)
                n = Convert.ToInt32(nums[i].ToString() + nums[j].ToString());
            else
                n = nums[i];
            sum += n;
            i++;
            j--;
        }
        return sum;
    }
}