public class Solution {
    public IList<IList<int>> LargeGroupPositions(string s) {
        List<IList<int>> ans = new List<IList<int>>();
        for (int i = 0; i < s.Length - 1; i++)
        {
            int j = i + 1;
            while (j < s.Length && s[j] == s[i])
                j++;
            if (j - i >= 3)
            {
                ans.Add(new List<int>(){i, j - 1});
                i = j - 1;
            }
        }
        return ans;
    }
}