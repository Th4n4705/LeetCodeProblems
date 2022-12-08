public class Solution {
    public int SumOfUnique(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        
        Dictionary<int,int> duplicationDic = new();
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (duplicationDic.ContainsKey(nums[i]))
                duplicationDic[nums[i]]++;
            else
                duplicationDic.Add(nums[i],1);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (duplicationDic[nums[i]] == 1)
                sum += nums[i];
        }

        return sum;
    }
}