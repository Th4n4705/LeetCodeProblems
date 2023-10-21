public class Solution {
    public int MaximumValue(string[] strs) {
        int ans = 0;
        foreach (string str in strs)
            ans = Math.Max(ans, StringToInt(str));
        return ans;
    }

    private int StringToInt(string str)
    {
        try
        {
            return Int32.Parse(str);
        }
        catch
        {}
        return str.Length;
    }
}