public class Solution {
    public int CompareVersion(string version1, string version2) {
        int i = 0;
        int j = 0;
        while (i < version1.Length || j < version2.Length)
        {
            int n1 = 0;
            int n2 = 0;
            while (i < version1.Length && version1[i] != '.')
            {
                n1 = n1 * 10 + (version1[i] - '0');
                i++;
            }
            while (j < version2.Length && version2[j] != '.')
            {
                n2 = n2 * 10 + (version2[j] - '0');
                j++;
            }
            if (n1 < n2)
                return -1;
            else if (n1 > n2)
                return 1;
            i++;
            j++;
        }
        return 0;
    }
}