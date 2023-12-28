public class Solution {
    public int SubsetXORSum(int[] nums) {
        return XORSum (nums, 0, 0);
    }

    private int XORSum (int[] nums, int i, int res)
    {
        if (i == nums.Length)
            return res;
        return XORSum (nums, i + 1, res) + XORSum (nums, i + 1, res ^ nums[i]);
    }
}