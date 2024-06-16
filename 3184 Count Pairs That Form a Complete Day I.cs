public class Solution {
    public int CountCompleteDayPairs(int[] hours) {
        int counter = 0;
        Dictionary<int, int> dc = new();
        for (int i = 0; i < hours.Length; i++)
        {
            int hour = hours[i] % 24;
            if (dc.ContainsKey((24 - hour) % 24))
                counter += dc[(24 - hour) % 24];
            if (!dc.TryAdd(hour, 1))
                dc[hour]++;
        }
        return counter;
    }
}