public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int i = 0;
        while (i < nums.Length)
        {
            if ((nums[i] % 2 == 0 && i % 2 == 0) || (nums[i] % 2 != 0 && i % 2 != 0))
            {
                i++;
                continue;
            }
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] % 2 == 0 && nums[j] % 2 != 0) || (nums[i] % 2 != 0 && nums[j] % 2 == 0))
                {
                    int tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                    break;
                }
            }
            i++;
        }
        return nums;
    }
}