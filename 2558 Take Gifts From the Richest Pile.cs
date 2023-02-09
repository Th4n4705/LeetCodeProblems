public class Solution {
    public long PickGifts(int[] gifts, int k) {
        for (int i = 0; i < k; i++)
        {
            int max = gifts.Max();
            int rest = (int)Math.Floor(Math.Sqrt(max));
            for (int j = 0; j < gifts.Length; j++)
            {
                if (gifts[j] == max)
                {
                    gifts[j] = rest;
                    break;
                }
            }
        }
        return gifts.Sum(g => (long)g);
    }
}