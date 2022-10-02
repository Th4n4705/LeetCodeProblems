public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        IList<int> indexList = new List<int>();
        List<int> numsList = nums.ToList();
        numsList.Sort();
        int i = 0;
        
        while (i < numsList.Count)
        {
            if (numsList[i] == target)
                indexList.Add(i);
            
            i++;
        }
        
        return indexList;
    }
}