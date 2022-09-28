public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        
        int newOriginal  = original;
        List<int> numsList = nums.ToList();
        int i =  0;
        
        numsList.Sort();
        
        while (i < numsList.Count)
        {
            if  (numsList[i] == newOriginal)
                newOriginal *= 2;
            i++;
        }
        
        return newOriginal;
    }
}