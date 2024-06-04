public class Solution {
    public int LongestPalindrome(string s) {
        int ans = 0;
        int[] arr = new int[123];
        foreach (char c in s)
            arr[c]++;
        foreach (int n in arr)
        {
            ans += (n / 2) * 2;
            if (ans % 2 == 0 && n % 2 == 1)
                ans++;
        }
        return ans;
    }
}