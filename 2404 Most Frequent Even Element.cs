public class Solution {
    public int MostFrequentEven(int[] nums) {
        
        List<int> numsList = nums.ToList();
        numsList.Sort();
        
        int i = 0;
        int mostRepeated = -1;
        int repeatedValue = 0;

        while (i < numsList.Count)
        {
            if (numsList[i] % 2 == 0)
            {
                int counted = ElementCalculator(numsList, numsList[i]);
                if (repeatedValue < counted)
                {
                    repeatedValue = counted;
                    mostRepeated = numsList[i];
                }
            }
            i++;
        }
        return mostRepeated;
    }
    
    public int ElementCalculator(List<int> numsList, int target)
    {
        int i = 0;
        int counter = 0;
        
        while (i < numsList.Count)
        {
            if (target == numsList[i])
                counter++;
            i++;
        }
        return counter;
    }
}