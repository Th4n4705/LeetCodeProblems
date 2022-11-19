public class Solution {
    public int MinimumOperations(int[] nums) {
        int counter = 0;
        bool checker = false;
        while (!checker)
        {
            Array.Sort(nums);
            int x = ChoseX(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] > 0)
                    nums[i] = nums[i] - x;
            }
            if (sum <= 0)
                checker = true;
            else
                counter++;
            x++;
        }
        return counter;
    }
    
    int ChoseX(int[] nums)
    {
        for (int i = 0; i < nums.Length;i++)
            if (nums[i] != 0)
                return nums[i];
        return 0;
    }
}