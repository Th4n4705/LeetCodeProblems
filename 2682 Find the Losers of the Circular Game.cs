public class Solution {
    public int[] CircularGameLosers(int n, int k) {
        int current = 0;
        HashSet<int> visited = new() {current};
        int turn = 1;
        while (true)
        {
            current = (current + k * turn) % n;
            if (visited.Contains(current))
                break;
            visited.Add(current);
            turn++;
        }
        int[] losers = new int[n - visited.Count];
        int index = 0;
        for (int i = 0; i < n; i++)
            if (!visited.Contains(i))
            {
                losers[index] = i + 1;
                index++;
            }
        return losers;
    }
}