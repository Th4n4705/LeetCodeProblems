public class Solution {
    public int MostFrequent(int[] nums, int key) {
        List<int> frequentN = new List<int>();
        int i = 0;
        
        while (i < nums.Length)
        {
            if (nums[i] == key)
            {
                if (i + 1 < nums.Length)
                    frequentN.Add(nums[i + 1]);
                
            }
            i++;
        }
        
        i = 0;
        int focusedInt = -100;
        int focusedCounter = 0;
        
        while (i < frequentN.Count)
        {
            if (focusedInt == -100 || focusedInt !=  frequentN[i])
            {
                int j = 0;
                int counter = 0;
                while (j < frequentN.Count)
                {
                    if (frequentN[i] == frequentN[j])
                        counter++;
                    j++;
                }
                if (counter > focusedCounter)
                {
                    focusedCounter = counter;
                    focusedInt = frequentN[i];
                }
            }
            i++;
        }
        
        return focusedInt;
    }
}