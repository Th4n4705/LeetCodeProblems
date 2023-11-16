public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if (s1 == s2)
            return true;
        int[] arr = new int[26];
        int counter = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                if (counter == 2)
                    return false;
                counter++;
            }
            arr[s1[i] - 'a']++;
            arr[s2[i] - 'a']--;
        }
        return counter <= 2 && arr.All(c => c == 0);
    }
}