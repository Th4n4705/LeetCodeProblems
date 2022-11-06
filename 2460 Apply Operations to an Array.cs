public class Solution {
    public int[] ApplyOperations(int[] nums) {
        List<int> numsList = new List<int>();
        bool zeroVal = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (zeroVal || nums[i] == 0)
            {
                zeroVal = false;
            }
            else if (i + 1 < nums.Length && nums[i] == nums[i + 1])
            {
                numsList.Add(nums[i] * 2);
                zeroVal = true;
            }
            else
                numsList.Add(nums[i]);
        }
        
        for (int i = nums.Length - numsList.Count - 1; i >= 0; i--)
            numsList.Add(0);
        
        return numsList.ToArray();
    }
}