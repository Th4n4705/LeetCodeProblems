public class Solution {
    public bool FindSubarrays(int[] nums) {
        List<int> numsList = nums.ToList();
        
        int i = 0;
        int countList = numsList.Count;
        
        while (i < countList)
        {
            bool result = SubarraysChecker(numsList, i);
            if (result)
                return true;
            i++;
        }
        return false;
    }
    
    public bool SubarraysChecker(List<int> list, int index)
    {
        int i = index;
        int countList = list.Count;
        
        if ( i == 0 || i + 1 == countList)
            return false;
        
        while (i < countList)
        {
            if ((i + 1 < countList) && (list[i] + list[i + 1] == list[index] + list[index - 1]))
                return true;
            i++;
        }
        return false;
    }
}