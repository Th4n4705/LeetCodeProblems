public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int[] ans = new int[code.Length];
        for (int i = 0; i < code.Length; i++)
        {
            if (k > 0)
                for (int j = i + 1; j < i + k + 1; j++)
                    ans[i] += code[j % code.Length];
            else if (k < 0)
                for (int j = i - 1; j > i + k - 1; j--)
                    ans[i] += code[(j + code.Length) % code.Length];
        }
        return ans;
    }
}