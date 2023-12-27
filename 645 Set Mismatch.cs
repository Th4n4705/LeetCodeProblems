public class Solution {
    public int[] FindErrorNums(int[] nums) {
        Array.Sort(nums);
        int missing = -1;
        int duplicated = -1;
        for (int i = 1; i <= nums.Length; i++)
        {
            int counter = 0;
            foreach (int n in nums)
                if (n == i)
                    counter++;
            if (counter != 1)
            {
                if (counter == 0)
                    missing = i;
                if (counter == 2)
                    duplicated = i;
            }
        }
        return new int[] {duplicated, missing};
    }
}