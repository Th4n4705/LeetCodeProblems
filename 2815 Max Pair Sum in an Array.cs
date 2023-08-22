public class Solution {
    public int MaxSum(int[] nums) {
        Dictionary<int, List<int>> dc = new ();
        int ans = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            char[] ch = nums[i].ToString().ToCharArray();
            int maxDigit = 0;
            foreach (char c in ch)
                maxDigit = Math.Max(maxDigit, c - '0');
            if (!dc.ContainsKey(maxDigit))
                dc.Add(maxDigit, new List<int>());
            dc[maxDigit].Add(nums[i]);
        }
        foreach (int key in dc.Keys)
        {
            if (dc[key].Count < 2)
                continue;
            dc[key].Sort();
            ans = Math.Max(ans, dc[key][dc[key].Count - 1] + dc[key][dc[key].Count - 2]);
        }
        return ans;
    }
    
}