public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        IList<int> result = new List<int>();
        int i = 0;
        
        while (i < nums.Length)
        {
            if (nums[i] == key)
            {
                FillList(result, nums, k, i);
            }
            i++;
        }
        
        result = result.Distinct().ToList();
        
        return result;
    }
    
    public void FillList(IList<int> result, int[] nums, int k, int index)
    {
        int i = index - k;
        
        while (i < nums.Length)
        {
            if (i >= 0)
                result.Add(i);
            if (i > index + k - 1)
                break;
            i++;
        }
    }
}