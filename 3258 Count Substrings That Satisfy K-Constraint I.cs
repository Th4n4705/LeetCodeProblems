public class Solution {
    public int CountKConstraintSubstrings(string s, int k) {
        int left = 0;
        int right = 0;
        int zero = 0;
        int one = 0;
        int counter = 0;
        while(right < s.Length)
        {
            if (s[right] == '0')
                zero++;
            else
                one++;
            while (zero > k && one > k)
                if (s[left++] == '0')
                    zero--;
                else
                    one--;
            counter += right - left + 1;
            right++;
        }
        return counter;
    }
}