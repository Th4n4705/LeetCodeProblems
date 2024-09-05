public class Solution {
    public string ReverseStr(string s, int k) {
        char[] arr = s.ToCharArray();
        for (int i = 0; i < s.Length; i += 2 * k)
        {
            int l = i;
            int j = Math.Min(i + k - 1, s.Length - 1);
            while (l < j)
            {
                (arr[l],arr[j]) = (arr[j],arr[l]);
                l++;
                j--;
            }
        }
        return new string(arr);
    }
}