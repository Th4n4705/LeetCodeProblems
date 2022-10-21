public class Solution {
    public int FindMaxK(int[] nums) {
        Array.Sort(nums);
        int j = nums.Length - 1;
        int i;
        
        while (j >= 0)
        {
            if (nums[j] <= 0)
                break;
            i = 0;
            while (i < j)
            {
                if (nums[i] >= 0)
                    break;
                if (nums[i] == nums[j] * (-1))
                {
                 //   if (FindZero(nums[j]))
                        return nums[j];
                }
                i++;
            }
            j--;
        }
        return -1;
    }
    /*
    public bool FindZero(int a)
    {
        string s = a.ToString();
        int i = 0;
        
        while (i < s.Length)
        {
            if (s[i] == '0')
                return false;
            i++;
        }
        
        return true;
    }*/
}