public class Solution {
    public int CountPairs(int[] nums, int k) {
        int counter = 0;
        List<int> PairList = new();
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && (i * j) % k == 0)
                {
                    PairList.Add(i);
                    counter++;
                }
            }
        }
        
        return counter;
    }
}