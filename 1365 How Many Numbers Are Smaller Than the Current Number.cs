public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        List<int> a = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int counter = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                    counter++;
            }
            a.Add(counter);
        }
        return a.ToArray();
    }
}