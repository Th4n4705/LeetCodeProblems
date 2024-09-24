public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        int ans = 0;
        HashSet<int> hs = new();
        foreach (int a in arr1)
        {
            int curr = a;
            while (curr > 0)
            {
                if (!hs.Contains(curr))
                    hs.Add(curr);
                curr /= 10;
            }
        }
        foreach(int b in arr2)
        {
            int curr = b;
            while (!hs.Contains(curr) && curr > 0)
                curr /= 10;
            if (curr > 0)
                ans = Math.Max(ans, (int)Math.Log10(curr) + 1);
        }
        return ans;
    }
}