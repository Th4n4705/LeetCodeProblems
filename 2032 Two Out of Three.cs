public class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        IList<int> resultList = new List<int>();
        int i = 0;
        int nums1Length = nums1.Length;
        int nums2Length = nums2.Length;
        
        while (i < nums1Length || i < nums2Length)
        {
            if (i < nums1Length)
            {
                searchElement(nums2, nums1[i], resultList);
                searchElement(nums3, nums1[i], resultList);
            }
            if (i < nums2Length)
                searchElement(nums3, nums2[i], resultList);
            i++;
        }
        // remove duplicate data
        resultList = resultList.Distinct().ToList();
        
        return resultList;
    }
    
    public bool searchElement(int[] nums, int Value, IList<int> List)
    {
        int i = 0;
        
        while (i < nums.Length)
        {
            if (nums[i] == Value)
            {
                List.Add(Value);
                return true;
            }
            
            i++;
        }
        
        return false;
    }
}