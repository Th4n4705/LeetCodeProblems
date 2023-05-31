public class Solution {
    public string RemoveTrailingZeros(string num) {
        int i = 0;
        int j = num.Length - 1;
        while (i < j)
        {
            if (num[i] == '0')
                i++;
            if (num[j] == '0')
                j--;
            if (num[i] != '0' && num[j] != '0')
                break;
        }
        return num.Substring(i, j + 1 - i);
    }
}