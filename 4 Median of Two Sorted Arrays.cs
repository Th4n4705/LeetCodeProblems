public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> fullList = new List<int>();
        
        FillArray(nums1, nums2, fullList);
        
        if (fullList.Count % 2 == 0)
            return ((double)fullList[fullList.Count / 2 - 1] + (double)fullList[fullList.Count/ 2]) / 2;
        return fullList[fullList.Count / 2];
    }
    
    public void FillArray(int[] nums1, int[] nums2, List<int> ListToFill)
    {
        int i = 0;
        
        while (i < nums1.Length)
        {
            ListToFill.Add(nums1[i]);
            i++;
        }
        
        i = 0;
        
        while (i < nums2.Length)
        {
            ListToFill.Add(nums2[i]);
            i++;
        }
        
        SortingList(ListToFill);
    }
    
    public void SortingList(List<int> ListToFill)
    {
        int i = 0;
        int j;
        int tmp;
        
        while (i < ListToFill.Count)
        {
            j = i;
            while (j < ListToFill.Count)
            {
                if (ListToFill[i] > ListToFill[j])
                {
                    tmp = ListToFill[i];
                    ListToFill[i] = ListToFill[j];
                    ListToFill[j] = tmp;
                }
                j++;
            }
            i++;
        }
    }
}