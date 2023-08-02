public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> ans = new();
        Helper (ans, new HashSet<int>(), nums);
        return ans;    
    }

    private void Helper(List<IList<int>> ans, HashSet<int> hs, int[] nums)
    {
        if (hs.Count == nums.Length)
        {
            ans.Add(new List<int>(hs));
            return ;
        }
        foreach (int n in nums)
            if (hs.Add(n))
            {
                Helper (ans, hs, nums);
                hs.Remove(n);
            }
    }
}