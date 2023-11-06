public class Solution {
    public bool CheckDistances(string s, int[] distance) {
        int[] arr = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            int j = s[i] - 'a';
            if (arr[j] == 0)
                arr[j] = i + 1;
            else if (i - arr[j] != distance[j])
                return false;
        }
        return true;
    }
}