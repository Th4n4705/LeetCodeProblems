public class Solution {
    public string LicenseKeyFormatting(string s, int k) {
        char[] arr = new char[k];
        int tmp = k;
        Stack<string> ans = new();
        for (int i = s.Length - 1; i >= 0; i--)
            if (s[i] != '-')
            {
                arr[--tmp] = s[i];
                if (tmp == 0)
                {
                    ans.Push(new string(arr));
                    tmp = k;
                }
            }
        if (tmp > 0 && tmp != k)
            ans.Push(new string(arr, tmp, arr.Length - tmp));
        return string.Join("-", ans.Select(a => a.ToUpper()));
    }
}