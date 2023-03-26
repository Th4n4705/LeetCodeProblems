public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> dcRoman = new Dictionary<char, int>{{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};
        int ans = 0;
        s = s.Replace("IV","IIII");
        s = s.Replace("IX","VIIII");
        s = s.Replace("XL","XXXX");
        s = s.Replace("XC","LXXXX");
        s = s.Replace("CD","CCCC");
        s = s.Replace("CM","DCCCC");
        for (int i = 0; i < s.Length; i++)
            ans += dcRoman[s[i]];
        return ans;
    }
}