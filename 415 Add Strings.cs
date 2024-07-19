public class Solution {
    public string AddStrings(string num1, string num2) {
        string ans = string.Empty;
        int n1 = num1.Length - 1;
        int n2 = num2.Length - 1;
        int rest = 0;
        while (n1 >= 0 || n2 >= 0)
        {
            int sSum = 0;
            if (n1 >= 0)
                sSum += int.Parse("" + num1[n1]);
            if (n2 >= 0)
                sSum += int.Parse("" + num2[n2]);
            int bSum = sSum + rest;
            ans = (bSum % 10) + ans;
            rest = bSum / 10;
            n1--;
            n2--;
        }
        return rest > 0 ? rest + ans : ans;
    }
}