public class Solution {
    public int FindMinimumOperations(string s1, string s2, string s3) {
        int counter = 0;
        int length = Math.Min (s1.Length, Math.Min (s2.Length, s3.Length));
        for (int i = 0; i < length; i++)
            if (s1[i] == s2[i] && s1[i] == s3[i])
                counter++;
            else
                break;
        return counter < 1 ? -1 : s1.Length + s2.Length + s3.Length - (counter * 3);
    }
}