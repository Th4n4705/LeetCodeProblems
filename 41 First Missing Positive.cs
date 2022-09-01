public class Solution {
    public int FirstMissingPositive(int[] nums) {
        List<int> numsList = new List<int>();
        
        numsList = nums.ToList();
        numsList.Sort();
        numsList = numsList.Distinct().ToList(); // remove duplication if founded
        int i = 0;
        int checker = 1;
        
        while (i < numsList.Count)
        {
            if (numsList[i] <= 0)
                i++;
            else
                break;
        }
        
        while (i < numsList.Count)
        {
            if (numsList[i] != checker)
                return checker;
            checker++;
            i++;
        }
        return checker++;
    }
}
