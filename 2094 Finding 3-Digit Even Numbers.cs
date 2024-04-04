public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        List<int> ans = new();
        int even = 0;
        for (int i = 0; i < digits.Length; i++)
            if (digits[i] > 0)
                for (int j = 0; j < digits.Length; j++)
                    for (int k = 0; k < digits.Length; k++)
                        if (i != j && j != k && i != k)
                        {
                            even = (digits[i] * 100) + (digits[j] * 10) + digits[k];
                            if (even % 2 == 0 && ans.IndexOf(even) == -1)
                                ans.Add(even);
                        }
        ans.Sort();
        return ans.ToArray();
    }
}