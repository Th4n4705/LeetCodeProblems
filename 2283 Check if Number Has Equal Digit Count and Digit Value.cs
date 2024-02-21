public class Solution {
    public bool DigitCount(string num) {
        if (num.Length == 1)
            return false;
        int[] arr = new int[10];
        foreach (char c in num)
            arr[c - '0']++;
        for (int i = 0; i < num.Length; i++)
            if (num[i] - '0' != arr[i])
                return false;
        return true;
    }
}