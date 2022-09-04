public class Solution {
    public int ThirdMax(int[] nums) {
        List<int> numsList = new List<int>();
        
        numsList = nums.ToList();
        numsList = numsList.Distinct().ToList(); // remove duplication if founded
        numsList.Sort();
        int i = numsList.Count - 1;
        int listLength = i;
        while (0 <= i)
        {
            if (i == listLength - 2)
                return (numsList[i]);
            i--;
        }
        return (numsList[listLength]);
    }
}