public class Solution {
    public void ReverseString(char[] s) {
        
        int i = 0;
        int j = s.Length - 1;
        char tmp;

        while (i < j)
        {
            tmp = s[j];
            s[j] = s[i];
            s[i] = tmp;
            i++;
            j--;
        }
    }
}