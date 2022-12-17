public class Solution {
    public int MinOperations(int[] nums) {
        int counter = 0;
        bool isNotOk = true;
        while (isNotOk)
        {
            bool isIncre = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i - 1 >= 0 && nums[i] <= nums[i - 1])
                {
                    counter++;
                    nums[i]++;
                    isIncre = false;
                }
            }
            isNotOk = !isIncre;
        }
        return counter;
    }
}