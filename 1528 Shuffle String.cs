public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] ch = new char[indices.Length];
        for (int i = 0; i < indices.Length; i++)
            ch[indices[i]] = s[i];
        return new string(ch);
    }
}