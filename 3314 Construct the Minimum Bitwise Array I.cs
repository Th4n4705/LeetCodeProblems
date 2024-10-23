public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
        List<int> ls = new();
        foreach (int n in nums)
        {
            bool IsPrime = false;
            for (int i = 0; i < n; i++)
            {
                int ans = i | i + 1;
                if (n == ans)
                {
                    IsPrime = true;
                    ls.Add(i);
                    break;
                }
            }
            if (!IsPrime)
                ls.Add(-1);
        }
        return ls.ToArray();
    }
}