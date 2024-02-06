public class Solution {
    public int[] DiStringMatch(string s) {
        int[] ans = new int[s.Length + 1];
        int left = 0;
        int right = s.Length;
        for (int i = 0; i < s.Length; i++)
            ans[i] = (s[i] == 'I') ? left++ : right--;
        ans[s.Length] = left;
        return ans;
    }
}