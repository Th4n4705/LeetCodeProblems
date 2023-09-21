public class Solution {
    public int SumIndicesWithKSetBits(IList<int> nums, int k) {
        return nums.Where((m, n) => CountOnes(n) == k).Sum();
    }

    private int CountOnes(int n)
    {
        int counter = 0;
        while (n != 0)
        {
            if ((n & 1) == 1)
                ++counter;
            n >>= 1;
        }
        return counter;
    }
}