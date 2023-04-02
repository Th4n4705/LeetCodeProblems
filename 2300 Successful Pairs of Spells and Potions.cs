public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        List<int> pairs = new();
        Array.Sort(potions);
        foreach (var spell in spells)
        {
            int left = 0;
            int right = potions.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long product = (long) spell * potions[mid];
                if (product >= success)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            pairs.Add(potions.Length - left);
        }
        return pairs.ToArray();
    }
}