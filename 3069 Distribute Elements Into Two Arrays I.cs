public class Solution {
    public int[] ResultArray(int[] nums) {
        List<int> ls = new(){nums[0]};
        List<int> ls1 = new(){nums[1]};
        for (int i = 2; i < nums.Length; i++)
            if (ls[ls.Count - 1] > ls1[ls1.Count - 1])
                ls.Add(nums[i]);
            else
                ls1.Add(nums[i]);
        List<int> ans = new();
        foreach (int n in  ls)
            ans.Add(n);
        foreach (int n in  ls1)
            ans.Add(n);
        return ans.ToArray();
    }
}