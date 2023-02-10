public class Solution {
    public int[] SeparateDigits(int[] nums) {
        List<int> ls = new();
        foreach (var n in nums)
        {
            string nS = n.ToString();
            if (n > 9)
                for (int i = 0; i < nS.Length; i++)
                    ls.Add(Convert.ToInt32(nS[i].ToString()));
            else
                    ls.Add(n);
        }
        return ls.ToArray();
    }
}