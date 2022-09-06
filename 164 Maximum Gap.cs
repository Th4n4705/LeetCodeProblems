public class Solution {
    public int MaximumGap(int[] nums) {
        List<int> numsList = new List<int>();
        numsList = nums.ToList();
        
        if (numsList.Count < 2)
            return 0;
        
        numsList.Sort();
        int maxGap = 0;
        
        for (int i = 0; i < numsList.Count; i++)
            if (i + 1 < numsList.Count && maxGap < numsList[i + 1] - numsList[i])
                maxGap = numsList[i + 1] - numsList[i];
        return maxGap;
    }
}