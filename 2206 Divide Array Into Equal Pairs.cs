public class Solution {
    public bool DivideArray(int[] nums) {
        if (nums.Length % 2 != 0)
            return false;
        
        List<int> opnersList = new();
        for (int i = 0; i <  nums.Length; i++)
        {
            if (opnersList.IndexOf(nums[i]) != -1)
                opnersList.Remove(nums[i]);
            else
                opnersList.Add(nums[i]);
        }
        if (opnersList.Count > 0)
            return false;
        return true;
    }
}