public class Solution {
    public int GetLucky(string s, int k) {
        string full_num = Converter(s);
        for (int i = 0; i < k; i++)
            full_num = Transform(full_num);

        return Convert.ToInt32(full_num);
    }
    
    public string Converter(string s)
    {
        string result = String.Empty;
        for (int i = 0; i < s.Length; i++)
            result += (s[i] - 96).ToString();
        
        return result;
    }
    
    public string Transform(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
            result += int.Parse(s[i].ToString());
        
        return result.ToString();
    }
}