public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

        List<int> allLists = new List<int>();
        
        FillList(allLists, nums1, m);
        FillList(allLists, nums2, n);

        allLists.Sort();
        FillNum(allLists, nums1);
    }
    
    public void FillList(List<int> allLists, int[] nums, int max)
    {
        int i = 0;
        
        while (i < max)
        {
            allLists.Add(nums[i]);
            i++;
        }
    }
    
    public void FillNum(List<int> allLists, int[] nums)
    {
        int i = 0;
        
        foreach (int element in allLists)
        {
            nums[i] = element;
            i++;
        }
    }
}