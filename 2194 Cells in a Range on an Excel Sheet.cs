public class Solution {
    public IList<string> CellsInRange(string s) {
        List<string> ans = new();
        for (char c = s[0]; c <= s[3]; c++)
            for (char r = s[1]; r <= s[4]; r++)
                ans.Add(c +""+ r);
        return ans;
    }
}